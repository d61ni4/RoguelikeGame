using System;

class Tree {
    private Random rnd = new Random();
    private Container leaf;
    private Tree lchild;
    private Tree rchild;

    public Tree Lchild {
        get {
            return lchild;
        }
        set {
            lchild = value;
        }
    }
    public Tree Rchild {
        get {
            return rchild;
        }
        set {
            rchild = value;
        }
    }
    public Container Leaf {
        get {
            return leaf;
        }
        set {
            leaf = value;
        }
    }

    public Tree(Container leaf) {
        this.leaf = leaf;
    }

    public Tree Split(int numberOfIterations, Container container)
{
    Tree node = new Tree(container); 

    if (numberOfIterations == 0)
    {
        return node;
    }

    Container[] splitedContainer = SplitContainer(container);
    node.Lchild = Split(numberOfIterations - 1, splitedContainer[0]);

    node.Rchild = Split(numberOfIterations - 1, splitedContainer[1]);

    return node;
}

    private Container[] SplitContainer(Container container)
    {
    Container c1, c2;
    int horizontal = rnd.Next(0, 1);
    if (horizontal == 1)
    {
        c1 = new Container(container.Xcord, container.Ycord, (int)(container.Width * (rnd.Next(30, 60) / 100)), container.Height);
        c2 = new Container(container.Xcord + c1.Width, container.Ycord, container.Width - c1.Width, container.Height);
    }
    else
    {
        c1 = new Container(container.Xcord, container.Ycord, container.Width, (int)(container.Height * (rnd.Next(30, 60) / 100)));
        c2 = new Container(container.Xcord, container.Ycord + c1.Height, container.Width, container.Height - c1.Height);
    }
    return new Container[] { c1, c2 };
    }
    public void Paint() {
        Console.SetCursorPosition(this.leaf.Xcord, this.leaf.Ycord);
        for (int i = 0; i < this.leaf.Height; i++) {
            for (int j = 0; j < this.leaf.Width; j++){
                if ((i == 0) || (j == 0) || (i == this.leaf.Height - 1) || (j == this.leaf.Width - 1)) {
                    Console.Write('#');
                } else {
                    Console.Write('.');
                }
            }
             Console.SetCursorPosition(this.leaf.Xcord, this.leaf.Ycord+i+1);
        }
        if (this.Lchild != null) {
            this.Lchild.Paint();
        } else {}
        if (this.Rchild != null) this.Rchild.Paint();

    }
}

class Container {
    private Random rnd = new Random();
    private int xcord;
    private int ycord;
    private int width;
    private int height;
    private int centerY;
    private int centerX;
    public int Xcord {
        get {
            return xcord;
        }
        set {
            xcord = value;
        }
    }
    public int Ycord {
        get {
            return ycord;
        }
        set {
            ycord = value;
        }
    }
    public int Width {
        get {
            return width;
        }
        set {
            width = value;
        }
    }
    public int Height {
        get {
            return height;
        }
        set {
            height = value;
        }
    }
    public int CenterX {
        get {
            return centerX;
        }
    }
    public int CenterY {
        get {
            return centerY;
        }
    }
    public Container(int x, int y, int w, int h) {
        xcord = x;
        ycord = y;
        width = w;
        height = h;
        centerX = x + w / 2;
        centerY = y + h / 2;

    }

}