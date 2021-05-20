using System;
using UnityEngine;

namespace RPG.Saving {
    [Serializable]
    class SerializebleVector3 {
        public float x, y, z;

        public SerializebleVector3(Vector3 vector) {
            this.x = vector.x;
            this.y = vector.y;
            this.z = vector.z;
        }

        public Vector3 ToVector() {
            return new Vector3(x, y, z);
        }
    }
}