using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Immutable
{

    // simulate an RGB color class
    public sealed class Color
    {

        // this style of automatic property is obsolete
        // for Immutable types
        public byte Orange { get; private set; }

        // this is better, but slightly more verbose

        // this backing field must be set in the constructor
        // as there is no setter 
        private readonly byte _purple;

        public byte Purple
        {
            get { return _purple; }

        }


        // In C# 6 (released in 2015) you can create
        // read-only automatically-implemented properties:
        // this property can only be assigned in a constructor

        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }
        public byte Alpha { get; }


        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            IsWhite = (Red == 255 && Green == 255 && Blue == 255);
        }
        public Color(byte red)
        {
            Red = red;
            Green = 0;
            Blue = 0;
        }

        // ToString as a Pure function

        public override string ToString()
        {
            return $"Red: {Red}, Green: {Green}, Blue: {Blue}";
        }

        public bool IsBlack()
        {
            // instance methods must be pure
            return (Red == 0 && Green == 0 && Blue == 0);

        }

        // or implement as property

        public bool IsWhite { get; }

        public Color Lighten(byte lightenBy)
        {
            var redValue = (byte)Math.Clamp(value: Red + lightenBy, min: Red, max: Byte.MaxValue);
            var greenValue = (byte)Math.Clamp(value: Green + lightenBy, min: Green, max: Byte.MaxValue);
            var blueValue = (byte)Math.Clamp(value: Blue + lightenBy, min: Blue, max: Byte.MaxValue);
            return new Color(redValue, greenValue, blueValue);
        }

        public Color Darken(byte darkenBy)
        {
            var redValue = (byte)Math.Clamp(value: Red - darkenBy, min: Byte.MinValue, max: Red);
            var greenValue = (byte)Math.Clamp(value: Green - darkenBy, min: Byte.MinValue, max: Green);
            var blueValue = (byte)Math.Clamp(value: Blue - darkenBy, min: Byte.MinValue, max: Blue);
            return new Color(redValue, greenValue, blueValue);
        }

        private Color(byte red, byte green, byte blue, byte alpha)
        {

            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }


        public class Builder
        {
            private byte _red;
            private byte _green;
            private byte _blue;
            private byte _alpha;


            public Builder Red(byte red)
            {
                _red = red;
                return this;
            }
            public Builder Blue(byte blue)
            {
                _blue = blue;
                return this;
            }

            public Builder Green(byte green)
            {
                _green = green;
                return this;
            }
            public Builder Alpha(byte alpha)
            {
                _alpha = alpha;
                return this;
            }

            public Color Create()
            {
                return new Color(_red, _green, _blue, _alpha);
            }
        }
    }
}
