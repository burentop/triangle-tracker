using System;

namespace TriangleTracker {
    class Triangle
    {
        private int SideOne;
        private int SideTwo;
        private int SideThree;

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }

        public bool IsEquilateral()
        {
            return ((SideOne == SideTwo) && (SideTwo == SideThree));
        }

        public bool IsIsosceles()
        {
            return ((SideOne == SideTwo) || (SideTwo == SideThree) || (SideOne == SideThree));
        }
    }
}
