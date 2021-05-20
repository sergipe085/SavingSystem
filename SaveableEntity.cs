using System;
using System.Collections.Generic;
using RPG.Core;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Saving 
{
    [ExecuteAlways]
    public class SaveableEntity : MonoBehaviour
    {
        [SerializeField] private string UID = "";

        private static Dictionary<string, SaveableEntity> globalLookup = new Dictionary<string, SaveableEntity>();

        public string GetUID() {
            return UID;
        }

        public object CaptureState() {
            // return new SerializebleVector3(transform.position);
            Dictionary<string, object> state = new Dictionary<string, object>();
            foreach(ISaveable saveable in GetComponents<ISaveable>()) {
                state[saveable.GetType().ToString()] = saveable.CaptureState();
            }
            return state;
        }

        public void RestoreState(object state) {
            // SerializebleVector3 vector = state as SerializebleVector3;
            // GetComponent<NavMeshAgent>().Warp(vector.ToVector());
            // GetComponent<ActionScheduler>().CancelCurrentAction();

            Dictionary<string, object> stateDict = state as Dictionary<string, object>;
            foreach(ISaveable saveable in GetComponents<ISaveable>()) {
                string type = saveable.GetType().ToString();
                if (stateDict.ContainsKey(type)) {
                    saveable.RestoreState(stateDict[type]);
                }
            }
        }

        #if UNITY_EDITOR
        private void Update() {
            if (Application.IsPlaying(gameObject) || string.IsNullOrEmpty(gameObject.scene.path)) return;

            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty property = serializedObject.FindProperty("UID");

            if (string.IsNullOrEmpty(property.stringValue) || !IsUnique(property.stringValue)) {
                property.stringValue = System.Guid.NewGuid().ToString();
                serializedObject.ApplyModifiedProperties();
            }

            globalLookup[property.stringValue] = this;
        }
        #endif

        private bool IsUnique(string id) {
            if (!globalLookup.ContainsKey(id)) return true;
            if (globalLookup[id] == this) return true;

            if (globalLookup[id] == null)
            {
                globalLookup.Remove(id);
                return true;
            }

            if (globalLookup[id].GetUID() != id)
            {
                globalLookup.Remove(id);
                return true;
            }

            return false;
        }
    }
}