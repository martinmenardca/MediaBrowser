﻿using System.Collections.Generic;
using System.IO;
using System.Threading;
using MediaBrowser.Common.IO;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Providers;
using MediaBrowser.LocalMetadata.Parsers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Logging;

namespace MediaBrowser.LocalMetadata.Providers
{
    class AdultVideoXmlProvider : BaseXmlProvider<AdultVideo>
    {
        private readonly ILogger _logger;

        public AdultVideoXmlProvider(IFileSystem fileSystem, ILogger logger)
            : base(fileSystem)
        {
            _logger = logger;
        }

        protected override void Fetch(LocalMetadataResult<AdultVideo> result, string path, CancellationToken cancellationToken)
        {
            var chapters = new List<ChapterInfo>();

            new MovieXmlParser(_logger).Fetch(result.Item, chapters, path, cancellationToken);

            result.Chapters = chapters;
        }

        protected override FileSystemInfo GetXmlFile(ItemInfo info, IDirectoryService directoryService)
        {
            return MovieXmlProvider.GetXmlFileInfo(info, FileSystem);
        }
    }
}
