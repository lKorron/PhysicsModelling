using UnityEngine.Events;
namespace InputFields
{
    public interface ILengtheningTransformer
    {
        void SetLength(float length);
        UnityAction<string> ParseActionToString(UnityAction<float> method);
    }
}