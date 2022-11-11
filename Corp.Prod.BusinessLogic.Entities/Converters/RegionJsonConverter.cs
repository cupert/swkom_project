﻿using NetTopologySuite.Features;
using AutoMapper;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Prod.Area.Sub.DTOs.Converters
{
    internal class GeoJsonConverter :
        IValueConverter<string, NetTopologySuite.Geometries.Geometry>,
        IValueConverter<NetTopologySuite.Geometries.Geometry, string>
    {
        public Geometry Convert(string source, ResolutionContext context)
        {
            var serializer = NetTopologySuite.IO.GeoJsonSerializer.CreateDefault();
            var feature = (Feature)serializer.Deserialize(new StringReader(source), typeof(Feature));
            return feature?.Geometry;
        }

        public string Convert(Geometry sourceMember, ResolutionContext context)
        {
            Feature feature = new(sourceMember, null);

            var serializer = GeoJsonSerializer.CreateDefault();

            StringWriter writer = new();
            serializer.Serialize(writer, feature);
            writer.Flush();

            return writer.ToString();
        }
    }
}
