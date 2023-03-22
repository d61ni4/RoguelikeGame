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