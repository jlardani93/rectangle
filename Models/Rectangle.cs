using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private int _length;
        private int _width;

        public void SetLength(string newLength)
        {
            _length = Int32.Parse(newLength);
        }
        public void SetWidth(string newWidth)
        {
            _width = Int32.Parse(newWidth);
        }
        public string GetLength()
        {
            return _length.ToString();
        }
        public string GetWidth()
        {
            return _width.ToString();
        }
        public string GetArea()
        {
            return (_length * _width).ToString();
        }
        public bool IsSquare()
        {
            if (_length == _width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
