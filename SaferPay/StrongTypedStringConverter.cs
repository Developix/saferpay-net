using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SaferPay
{
	public class StrongTypedStringConverter : JsonConverter
	{
		private static Type[] _constructorTypes = new[] { typeof(string) };

		public override bool CanConvert(Type objectType)
		{
			var baseType = objectType.GetTypeInfo().BaseType.GetTypeInfo();
			return baseType.IsGenericType
				&& typeof(StrongTypedString<>).GetTypeInfo().IsAssignableFrom(baseType.GetGenericTypeDefinition().GetTypeInfo());
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var constructor = objectType.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)[0];
			return constructor.Invoke(new[] { reader.Value });
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString());
		}
	}
}
