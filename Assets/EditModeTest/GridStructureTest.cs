using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GridStructureTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CalculateGridPosPasses()
        {
            //Arrange
            GridStructure structure = new GridStructure(3);
            Vector3 pos = new Vector3(0, 0, 0);
            //Act
            Vector3 returnPos = structure.CalculateGridPos(pos);
            //Assert
            Assert.AreEqual(Vector3.zero,returnPos);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void CalculateGridPositionsPasses()
        {
            //Arrange
            GridStructure structure = new GridStructure(3);
            Vector3 pos = new Vector3(2.9f, 0, 2.9f);
            //Act
            Vector3 returnPos = structure.CalculateGridPos(pos);
            //Assert
            Assert.AreEqual(Vector3.zero,returnPos);
        }


    }
}
