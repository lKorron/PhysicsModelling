using UnityEngine;
using UnityEngine.Events;

namespace InputFields
{
    public class PositionField : DataField
    {
        protected override void Start()
        {
            base.Start();

            RopeTransformer _ropeTransformer = _transformer as RopeTransformer;
            UnityAction<string> action = _ropeTransformer.ParseActionToString(_ropeTransformer.SetPositionX);

            _inputField.onEndEdit.AddListener(action);
        }

        protected override void CheckFormat(string text)
        {
            if (float.TryParse(text, out _) == false && text != "-")
            {
                _inputField.text = "";
            }
        }
    }
}