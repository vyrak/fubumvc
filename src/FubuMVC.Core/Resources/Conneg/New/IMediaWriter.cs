using System.Collections.Generic;

namespace FubuMVC.Core.Resources.Conneg.New
{
    public interface IMediaWriter<T>
    {
        void Write(string mimeType, T resource);
        IEnumerable<string> Mimetypes { get; }
    }
}