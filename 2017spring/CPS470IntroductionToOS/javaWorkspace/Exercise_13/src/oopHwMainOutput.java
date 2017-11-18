public class oopHwMainOutput {

    public static void main(String[] args) {

        MyRectangle2D r1 = new MyRectangle2D(2, 2, 5.5, 4.9);

        System.out.println("Point 1: " + r1.getP1().toString());
        System.out.println("Point 2: " + r1.getP2().toString());
        System.out.println("Point 3: " + r1.getP3().toString());
        System.out.println("Point 4: " + r1.getP4().toString());
        System.out.println("Center point: " + r1.getCenterP().toString());
        System.out.println("\n\nArea = " + r1.getArea());
        System.out.println("Perimeter = " + r1.getPerimeter());
        System.out.println("Contains point 3,3: " + r1.contains(3,3));
        System.out.println("Contains r2: " + r1.contains(new MyRectangle2D(4, 5, 10.5, 3.2)));
        System.out.println("r2 over laps this rectangle: " + r1.overlaps(new MyRectangle2D(3, 5, 2.3, 5.4)));
    }
}
