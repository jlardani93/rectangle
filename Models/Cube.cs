using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RectangleProject.Models
{
    public class Cube
    {
        private int _surfaceArea;
        private int _volume;
        private int _id;
        private Rectangle _face;
        private static List<Cube> _cubes = new List<Cube>();

        public Cube(Rectangle newFace)
        {
            _face = newFace;
            _volume = Int32.Parse(_face.GetWidth()) * Int32.Parse(_face.GetLength()) * Int32.Parse(_face.GetWidth());
            _surfaceArea = (Int32.Parse(_face.GetArea()) * 6);
            _cubes.Add(this);
            _id = _cubes.Count;
        }
        public Rectangle GetFace()
        {
            return _face;
        }
        public string GetVolume()
        {
            return _volume.ToString();
        }
        public string GetSurfaceArea()
        {
            return _surfaceArea.ToString();
        }
        public int GetId()
        {
            return _id;
        }
        public static List<Cube> GetCubes()
        {
            return _cubes;
        }
        public static void ClearList()
        {
            _cubes.Clear();
        }
        public static Cube Find(int searchId)
        {
            return _cubes[searchId - 1];
        }
    }
}
