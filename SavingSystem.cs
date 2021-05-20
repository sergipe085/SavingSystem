using System;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Collections;

namespace RPG.Saving
{
    public class SavingSystem : MonoBehaviour
    {
        public IEnumerator LoadLastScene(string saveFile) {
            Dictionary<string, object> state = LoadFile(saveFile);
            if (state.ContainsKey("lastScene") && SceneManager.GetActiveScene().name != (string) state["lastScene"]) {
                yield return SceneManager.LoadSceneAsync((string)state["lastScene"]);
            }
            RestoreState(state);
        }

        public void Save(string saveFile) {
            print("Saving to " + GetPathFromSaveFile(saveFile));

            Dictionary<string, object> state = LoadFile(saveFile);
            CaptureState(state);
            SaveFile(saveFile, state);
        }

        public void Load(string saveFile) {
            print("Loading from " + GetPathFromSaveFile(saveFile));

            RestoreState(LoadFile(saveFile));
        }

        private Dictionary<string, object> LoadFile(string saveFile)
        {
            string path = GetPathFromSaveFile(saveFile);
            if (!File.Exists(path)) {
                return new Dictionary<string, object>();
            }
            using (FileStream stream = File.Open(path, FileMode.Open)) {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream) as Dictionary<string, object>;
            }
        }

        private void SaveFile(string saveFile, object state) {
            using (FileStream stream = File.Open(GetPathFromSaveFile(saveFile), FileMode.Create)) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, state);
            }
        }

        private void RestoreState(Dictionary<string, object> state) {
            foreach(SaveableEntity saveable in FindObjectsOfType<SaveableEntity>()) {
                string id = saveable.GetUID();
                if (state.ContainsKey(id)) {
                    saveable.RestoreState(state[id]);
                }
            }
        }

        private void CaptureState(Dictionary<string, object> state) {
            foreach(SaveableEntity saveable in FindObjectsOfType<SaveableEntity>()) {
                state[saveable.GetUID()] = saveable.CaptureState();
            }

            state["lastScene"] = SceneManager.GetActiveScene().name;
        }

        private string GetPathFromSaveFile(string saveFile) {
            return Path.Combine(Application.persistentDataPath, saveFile + ".sav");
        }
    }
}