using System;
using System.Collections;
using System.Text;


namespace BL
{
    public class JsonConvertor
    {
        private StringBuilder stringBuilder;
        private IEnumerable enumerable;
        private Type modelType;
        public JsonConvertor()
        {
            stringBuilder = new StringBuilder("[");


        }
        public string Convert(object model)
        {
            modelType = model.GetType();
            enumerable = model as IEnumerable;
            if (enumerable != null)
            {
                foreach (var item in enumerable)
                {
                    var str = ConvertProperties(item);
                }

                stringBuilder.Append("]");
            }
            return stringBuilder.ToString();
        }


        public StringBuilder ConvertProperties(object model)
        {
            modelType = model.GetType();
            var properties = modelType.GetProperties();
            stringBuilder.Append("{");
            for (var i = 0; i <= properties.Length - 1; i++)
            {
                if (!properties[i].IsDefined(typeof(MyIgnoreAttribute), false))
                {
                    stringBuilder.AppendFormat($"\"{ properties[i].Name }\": ");
                    if (i == properties.Length - 2)
                    {
                        stringBuilder.AppendFormat($"\"{properties[i].GetValue(model)}\"");
                    }
                    else
                        stringBuilder.AppendFormat($"{properties[i].GetValue(model)},");
                }
            }
            stringBuilder.Append("}\n");
            return stringBuilder;
        }

    }
}
