using UnityEngine;

namespace HeiHua
{
    public class Other
    {
        public string GetRandomString()
        {
            return Random.value.ToString();
        }
        public float GetRandomNumber(float max,float min)
        {
            return Random.Range(min,max);
        }
    }
}
