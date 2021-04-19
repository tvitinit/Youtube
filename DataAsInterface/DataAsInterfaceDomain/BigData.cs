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
Property2: {Property1}
Property3: {Property1}
Property4: {Property1}
Property5: {Property1}
Property6: {Property1}
Property7: {Property1}
ExtraProperty1: {ExtraProperty1}
ExtraProperty2: {ExtraProperty2}
ExtraProperty3: {ExtraProperty3}";
		}
	}
}
