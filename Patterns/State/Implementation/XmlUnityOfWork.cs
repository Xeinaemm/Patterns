using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Patterns.State.Contracts;

namespace Patterns.State.Implementation
{
	public class XmlUnityOfWork : IUnityOfWork
	{
		private readonly string dataFileName;
		private readonly XmlRepository<IEntity> entities;

		public XmlUnityOfWork(string fileName)
		{
			dataFileName = fileName;
			entities = new XmlRepository<IEntity>();

			if (!File.Exists(fileName))
				Commit();

			foreach (var workItem in ReadXml()) entities.Add(workItem);
		}

		public IRepository<IEntity> Entities => entities;

		public void Commit()
		{
			using (var writer = XmlWriter.Create(dataFileName))
			{
				writer.WriteStartDocument(true);
				writer.WriteStartElement("WorkItems");
				foreach (var y in Entities.FindAll())
				{
					var x = (WorkItem) y;
					writer.WriteStartElement("WorkItem");
					writer.WriteElementString("Id", x.Id.ToString());
					writer.WriteElementString("State", x.State);
					writer.WriteElementString("Title", x.Title);
					writer.WriteElementString("Description", x.Description);
					writer.WriteEndElement();
				}

				writer.WriteEndElement();
				writer.WriteEndDocument();
			}
		}

		private IEnumerable<WorkItem> ReadXml()
		{
			return
				XDocument.Load(dataFileName)
					.Element("WorkItems")
					.Elements("WorkItem")
					.Select(r => new WorkItem
					{
						Id = int.Parse(r.Element("Id")
							.Value),
						State = r.Element("State")
							.Value,
						Title = r.Element("Title")
							.Value,
						Description = r.Element("Description")
							.Value
					});
		}
	}
}