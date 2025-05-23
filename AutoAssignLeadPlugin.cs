using System;
using Microsoft.Xrm.Sdk;

namespace AutoAssignLeadPlugin
{
    public class AutoAssignLeadPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity entity)
            {
                if (entity.LogicalName != "lead") return;

                // Set the owner to a specific user (replace GUID with an actual user ID from your CRM)
                entity["ownerid"] = new EntityReference("systemuser", new Guid("00000000-0000-0000-0000-000000000001"));
            }
        }
    }
}
