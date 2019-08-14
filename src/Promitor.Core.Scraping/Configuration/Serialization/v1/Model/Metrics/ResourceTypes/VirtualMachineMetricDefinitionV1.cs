using Promitor.Core.Scraping.Configuration.Model;

namespace Promitor.Core.Scraping.Configuration.Serialization.v1.Model.Metrics.ResourceTypes
{
    public class VirtualMachineMetricDefinitionV1 : MetricDefinitionV1
    {
        public string VirtualMachineName { get; set; }
        public override ResourceType ResourceType { get; } = ResourceType.VirtualMachine;
    }
}