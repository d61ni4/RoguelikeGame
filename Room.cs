class Room {
    protected int height, width;
    protected Entity[,] map;
    protected List<Entity> entities;
    
    public Room(int width, int height, List<Entity> entities) {

        this.height = height;
        this.width = width;
        this.entities = entities;

        this.map = new Entity[width, height];
    }
    public Entity[,] getMap() {
        return this.map;
    }

    public void drawRoom() {

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                if ((i == 0) || (j == 0) || (j == height-1) || (i == width-1)) {
                    map[i, j] = new Wall();
                } else {
                    map[i, j] = new FreeSpace();
                }  
            }
        }

        foreach (Entity entity in entities) {
            map[entity.getCoordinates()[0], entity.getCoordinates()[1]] = entity;
        }

        for (int i = 0; i < this.height; i++) {
            for (int j = 0; j < this.width; j++) {
                Console.Write(this.map[j, i].getSymbol());
            }
            Console.WriteLine();
        }
    } 
}