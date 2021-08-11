package org.wx.notes;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ScannerTest {
    public static void main(String[] args) throws IOException {
//        System.out.println("请输入：");
//        Scanner scanner =new Scanner(System.in);
//        String s=scanner.nextLine();
//        System.out.println(s);

        System.out.println("请输入：");
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        String s = bufferedReader.readLine();
        System.out.println(s);
    }
}
