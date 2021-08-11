package org.wx.notes;

import org.junit.jupiter.api.Test;

import java.util.Scanner;

public class InTest {
    @Test
    void testIn() {
        System.out.println("请输入：");
        Scanner scanner = new Scanner(System.in);
        String s = scanner.nextLine();
        System.out.println(s);
    }
}
