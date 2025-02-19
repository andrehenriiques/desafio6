using desafio6.MsgContracts.Interface;
using MassTransit;

namespace desafio6.MsgContracts.Command
{
    public class ClientCommand(IPublishEndpoint publishEndpoint) : IClienCommand
    {
        public async Task PostClientRabbitMq(ClientAddressModel client)
        {
            await publishEndpoint.Publish(client,
                context => { context.SetRoutingKey("create-client"); });
        }
    }
}