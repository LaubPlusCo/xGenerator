﻿using System;
using Colossus;
using Newtonsoft.Json.Linq;

namespace ExperienceGenerator.Parsing.Factories
{
    public class LambdaFactory : VariableFactory
    {
        private readonly Action<VisitorSegment, JToken, XGenParser> _updateSegment;
        private readonly Action<VisitorSegment, XGenParser> _setDefaults;

        public LambdaFactory(Action<VisitorSegment, JToken, XGenParser> updateSegment = null, Action<VisitorSegment, XGenParser> setDefaults = null)
        {
            _updateSegment = updateSegment;
            _setDefaults = setDefaults;
        }

        public override void UpdateSegment(VisitorSegment segment, JToken definition, XGenParser parser)
        {
            _updateSegment?.Invoke(segment, definition, parser);
        }

        public override void SetDefaults(VisitorSegment segment, XGenParser parser)
        {
            _setDefaults?.Invoke(segment, parser);
        }
    }
}
