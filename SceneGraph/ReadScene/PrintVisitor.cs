using Han.ISceneGraph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Han.SceneGraph
{
    class PrintVisitor : IVisitor
    {
        #region Member Variables
        string currentIndentation = "";
        string indentIncrement = " ";
        #endregion

        public void PostVisit(IDrawableNode drawable)
        {
            currentIndentation = currentIndentation.Substring(0, currentIndentation.Length - indentIncrement.Length);

        }

        public void PostVisit(ITransformNode transform)
        {
            currentIndentation = currentIndentation.Substring(0, currentIndentation.Length - indentIncrement.Length);

        }

        public void PostVisit(IStateNode state)
        {
            currentIndentation = currentIndentation.Substring(0, currentIndentation.Length - indentIncrement.Length);

        }

        public void PostVisit(IGroupNode group)
        {
            currentIndentation = currentIndentation.Substring(0,currentIndentation.Length - indentIncrement.Length);
        }

        public void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation + "A Drawable node of type " + drawable.GetType().ToString() + " with name: " + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(ITransformNode transform)
        {
            System.Console.WriteLine(currentIndentation + "A Transform node of type " + transform.GetType().ToString() + " with name: " + transform.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IStateNode state)
        {
            System.Console.WriteLine(currentIndentation + "A State node of type " + state.GetType().ToString() + " with name: " + state.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IGroupNode group)
        {
            System.Console.WriteLine(currentIndentation + "A Group node of type " + group.GetType().ToString() + " with name: " + group.Name);
            currentIndentation += indentIncrement;
        }
    }
}
