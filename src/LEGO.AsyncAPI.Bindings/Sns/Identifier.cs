using System;
using LEGO.AsyncAPI.Models.Interfaces;
using LEGO.AsyncAPI.Writers;

namespace LEGO.AsyncAPI.Bindings.Sns;

public class Identifier : IAsyncApiElement
{
    public string Url { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Arn { get; set; }

    public string Name { get; set; }

    public void Serialize(IAsyncApiWriter writer)
    {
        if (writer is null)
        {
            throw new ArgumentNullException(nameof(writer));
        }

        writer.WriteStartObject();
        writer.WriteOptionalProperty("url", this.Url);
        writer.WriteOptionalProperty("email", this.Email);
        writer.WriteOptionalProperty("phone", this.Phone);
        writer.WriteOptionalProperty("arn", this.Arn);
        writer.WriteOptionalProperty("name", this.Name);
        writer.WriteEndObject();
    }
}