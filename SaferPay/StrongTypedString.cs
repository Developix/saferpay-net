using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaferPay
{
    public class StrongTypedString<T> : IEquatable<StrongTypedString<T>>
	{
		private string _value;
		protected StrongTypedString(string value) => _value = value;

		public bool Equals(StrongTypedString<T> other) => _value.Equals(other._value);
		public override bool Equals(object obj) => Equals(obj as StrongTypedString<T>);
		public override string ToString() => _value;

		public override int GetHashCode() => _value.GetHashCode();

		public static implicit operator String(StrongTypedString<T> obj) => obj._value;
		public static bool operator ==(StrongTypedString<T> a, StrongTypedString<T> b) => Equals(a, b);
		public static bool operator !=(StrongTypedString<T> a, StrongTypedString<T> b) => !Equals(a, b);
	}
}
