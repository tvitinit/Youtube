using System;

namespace DataAsInterfaceDomain
{
	public class BigData : IBigData
	{
		public string Property1 { get; set; }
		public string Property2 { get; set; }
		public string Property3 { get; set; }
		public string Property4 { get; set; }
		public string Property5 { get; set; }
		public string Property6 { get; set; }
		public string Property7 { get; set; }
		public string ExtraProperty1 { get; set; }
		public string ExtraProperty2 { get; set; }
		public string ExtraProperty3 { get; set; }

		public override string ToString()
		{
			return $@"Property1: {Property1}
Property2: {Property2}
Property3: {Property3}
Property4: {Property4}
Property5: {Property5}
Property6: {Property6}
Property7: {Property7}
ExtraProperty1: {ExtraProperty1}
ExtraProperty2: {ExtraProperty2}
ExtraProperty3: {ExtraProperty3}";
		}
	}
}
