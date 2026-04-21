import javax.swing.*;

public class Inter {
    private JTextField textField1;
    private JPanel panel1;
    private JButton ingresarButton;
    private JButton invertirButton;
    private JButton borrarButton;
    private JTextArea textArea1;
    private JTextArea textArea2;






    public static void main(String[] args) {
        JFrame frame = new JFrame("Inter");
        frame.setContentPane(new Inter().panel1);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}
