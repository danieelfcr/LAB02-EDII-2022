using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EDII
{
    class AVL<T>
    {
        public HuffmanNode<T> Root;
        public int count;
        public List<T> NodeList;
        Func<T, T, int> Comparer;
        Func<T, T, int> NameComparer;
        Action<T, T> EditInformation;


        public AVL(Func<T, T, int> Comparer)
        {
            Root = null;
            count = 0;
            NodeList = new List<T>();
            this.Comparer = Comparer;

        }



        public AVL(Func<T, T, int> Comparer, Func<T, T, int> NameComparer, Action<T, T> EditInformation)
        {
            Root = null;
            count = 0;
            NodeList = new List<T>();
            this.Comparer = Comparer;
            this.NameComparer = NameComparer;
            this.EditInformation = EditInformation;
        }



        public HuffmanNode<T> Insert(HuffmanNode<T> root, HuffmanNode<T> newNode)
        {
            //Base case
            if (root == null)
            {
                count++;
                return newNode; //retorna el nodo que se quiere insertar
            }

            if (Comparer(root.Record, newNode.Record) == 1)   //If it's lesser, go to left subtree
                root.Left = Insert(root.Left, newNode);
            else if (Comparer(root.Record, newNode.Record) == -1) //If it's greater, go to right subtree
                root.Right = Insert(root.Right, newNode);
            else return Root;


            //balance factor analysis

            int BalanceFactor = CalculateBalanceFactor(root);

            if (BalanceFactor > 1)
            {
                if (Comparer(root.Left.Record, newNode.Record) == 1) //Single right rotation
                    return RightRotation(root);
                else if (Comparer(root.Left.Record, newNode.Record) == -1) //Double right rotation
                {
                    root.Left = LeftRotation(root.Left);
                    return RightRotation(root);
                }
            }
            if (BalanceFactor < -1)
            {

                if (Comparer(root.Right.Record, newNode.Record) == -1) //Single right rotation 
                    return LeftRotation(root);
                else if (Comparer(root.Right.Record, newNode.Record) == 1)  //Double left rotation
                {
                    root.Right = RightRotation(root.Right);
                    return LeftRotation(root);
                }
            }
            return root;
        }

        public int GetHeight(HuffmanNode<T> node)
        {
            if (node == null)
                return -1;
            return Max(GetHeight(node.Left), GetHeight(node.Right));

        }

        public int Max(int leftHeight, int rightHeight)
        {
            return (leftHeight > rightHeight) ? leftHeight + 1 : rightHeight + 1;
        }

        public int CalculateBalanceFactor(HuffmanNode<T> node)
        {
            if (node == null)
                return -1;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }


        public HuffmanNode<T> RightRotation(HuffmanNode<T> node)
        {
            HuffmanNode<T> newRoot = node.Left;
            HuffmanNode<T> rightAux = newRoot.Right;
            newRoot.Right = node;
            node.Left = rightAux;

            return newRoot;
        }

        public HuffmanNode<T> LeftRotation(HuffmanNode<T> node)
        {
            HuffmanNode<T> newRoot = node.Right;
            HuffmanNode<T> leftAux = newRoot.Left;
            newRoot.Left = node;
            node.Right = leftAux;

            return newRoot;
        }

        public void SearchInOrder(HuffmanNode<T> root, HuffmanNode<T> node)
        {
            if (root == null) return;

            SearchInOrder(root.Left, node);

            if (NameComparer(root.Record, node.Record) == 0)
            {
                NodeList.Add(root.Record);
            }
            SearchInOrder(root.Right, node);
        }


        public bool Contains(HuffmanNode<T> root, HuffmanNode<T> newNode)
        {
            if (root != null)
            {
                if (Comparer(root.Record, newNode.Record) == 0) //Evaluate if they are the same
                {
                    return true;
                }
                else if ((Comparer(root.Record, newNode.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    return Contains(root.Left, newNode);
                }
                else if ((Comparer(root.Record, newNode.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    return Contains(root.Right, newNode);
                }
            }
            return false;
        }

        public HuffmanNode<T> Search(HuffmanNode<T> root, HuffmanNode<T> newNode)
        {
            if (root != null)
            {
                if (Comparer(root.Record, newNode.Record) == 0) //Evaluate if they are the same
                {
                    return root;
                }
                else if ((Comparer(root.Record, newNode.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    return Search(root.Left, newNode);
                }
                else if ((Comparer(root.Record, newNode.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    return Search(root.Right, newNode);
                }
            }
            return newNode;
        }

        public void EditData(HuffmanNode<T> root, HuffmanNode<T> nodeToEdit)
        {
            if (root != null)
            {
                if (Comparer(root.Record, nodeToEdit.Record) == 0) //Evaluate if they are the same
                {
                    EditInformation(root.Record, nodeToEdit.Record);
                }
                else if ((Comparer(root.Record, nodeToEdit.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    EditData(root.Left, nodeToEdit);
                }
                else if ((Comparer(root.Record, nodeToEdit.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    EditData(root.Right, nodeToEdit);
                }
            }
        }

        public HuffmanNode<T> Delete(HuffmanNode<T> root, HuffmanNode<T> DeleteNode)
        {
            if (root == null)
                return root;

            if (Comparer(root.Record, DeleteNode.Record) == 1)
            {
                root.Left = Delete(root.Left, DeleteNode);
            }

            else if (Comparer(root.Record, DeleteNode.Record) == -1)
            {
                root.Right = Delete(root.Right, DeleteNode);
            }

            else
            {
                if (root.Left == null || root.Right == null)
                {
                    HuffmanNode<T> aux = (root.Left != null) ? root.Left : root.Right;

                    if (aux == null)
                    {
                        aux = root;
                        root = null;
                    }
                    else
                    {
                        root = aux;
                        aux = null;

                    }
                }
                else
                {
                    HuffmanNode<T> aux = minValueNode(root.Right);
                    root.Record = aux.Record;
                    root.Right = Delete(root.Right, DeleteNode);
                }


            }


            return root;

            int balance = CalculateBalanceFactor(root);

            if (balance > 1)
            {
                if (Comparer(root.Record, DeleteNode.Record) == 1)
                {
                    //single right rotation
                    return RightRotation(root);
                }
                else if (Comparer(root.Record, DeleteNode.Record) == -1)
                {
                    //double roght rotation
                    root.Left = LeftRotation(root.Left);
                    return RightRotation(root);
                }
            }

            if (balance < -1)
            {
                if (Comparer(root.Record, DeleteNode.Record) == -1)
                {
                    //single left rotation
                    return LeftRotation(root);
                }
                else if (Comparer(root.Record, DeleteNode.Record) == 1)
                {
                    //double left rotation
                    root.Right = RightRotation(root.Right);
                    return LeftRotation(root);
                }
            }

        }

        HuffmanNode<T> minValueNode(HuffmanNode<T> node)
        {
            HuffmanNode<T> aux = node;
            if (node.Left != null)
            {
                aux = aux.Left;
            }
            return aux;
        }

    }
}

