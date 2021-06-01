# Module 6: Styling HTML5 by Using CSS3

# Lesson 2: Styling Block Elements

### Demonstration: Switching Between Cascading Style Sheets (CSS) Layout Models

#### Switch between layout modes in a webpage

In this demonstration we learn how to use the developers tools of Microsoft Edge, and how to change CSS rules in fly.

1. Open Microsoft Visual Studio 2017.

2. In Microsoft Visual Studio, on the **File** menu, point to **Open**, and then click **File**.

3. In the **Open File** dialog box, browse to the **[Repository Root]\Allfiles\Mod06\Democode** folder, click **positioning.html**, and then click **Open**.

4. Review the code with the students. This file contains an HTML **article** with four **div** elements. The file also contains styles for the **article** and **div** elements.

   ```html
        <!DOCTYPE html>
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
          <title>Positioning Demo</title>
          <style type="text/css">
            body {
              text-align: center;
            }
   
            article {
              padding: 10px;
              border: 2px solid red;
            }
   
            div {
              margin: 10px;
              padding: 5px;
              border: 2px solid black;
              width: 150px;
              height : 150px;
            }
   
            div:nth-child(odd) {
              font-size: 4rem;
            }
          </style>
        </head>
        <body>
          <article>
            <div id="one">One</div>
            <div id="two">Two</div>
            <div id="three">Three</div>
            <div id="four">Four</div>
          </article>
        </body>
        </html>
   ```

5. On the **File** menu, click **View in Brower (Microsoft Edge)**.

6. In Microsoft Edge, if the **Intranet settings are turned off by default** message appears, click **Don’t show this message again**.

7. Observe the four **div** elements laid out one below the other, in order, within the **article** element. To highlight its boundaries, the **article** element has a red border. This is the **block layout** mode.

   ![](D:\20480C\Allfiles\Mod06\Democode\pic00.png)

8. Press F12.

9. In the F12 Developer Tools Pane, click on **Dock Bottom** option on the top right corner, so that can see Both Microsoft Edge and Developer windows at the same time.
    ![](D:\20480C\Allfiles\Mod06\Democode\pic01.png)
    
10. To display the fully expanded version of the layout rules applied to the HTML content, click **Elements** tab.

11. In Elements tab expand **body** and expand **article**.

12. Right-click the **div** entry, and then select **Add attribute**.    ![](D:\20480C\Allfiles\Mod06\Democode\pic02.png)

13. Type **style=display: inline** for each **div** entry, and then press ENTER.    ![](D:\20480C\Allfiles\Mod06\Democode\pic03.png)

14. In Microsoft Edge, notice that the four **div** elements are now laid out side-by-side aligned by text baseline with height and width properties ignored. This is the **inline layout** mode.

15.	Resize the browser window to make it narrower, so you can see how the application wraps the blocks onto the next line in the **inline layout** mode.
16.	In the F12 Developer Tools window, on the **CSS** tab, click the **display: inline** rule, change it to read **display:inline-block**, and then press ENTER. ![](D:\20480C\Allfiles\Mod06\Democode\pic04.png)
17.	Notice the layout is the same but the **height** and **width** properties are now preserved. This is the **inline-block** mode.  ![](D:\20480C\Allfiles\Mod06\Democode\pic05.png)

>**Note**: If required, make the browser window wider so that blocks **One** and **Three** are on the same line.

18.	In Microsoft Edge, resize the browser window so you can see how the application wraps the blocks onto the next line in the **inline layout** mode.
19.	In the F12 Developer Tools window, on the **CSS** tab, click the **display: inline-block** rule. Change this rule to **display:-ms-flexbox**, and then press ENTER.
20.	To view the new layout, switch to Microsoft Edge. The application displays the **div** elements in a vertical column.
21.	In the F12 Developer Tools window, on the **CSS** tab, click the **display: -ms-flexbox** rule, change it to **display:table-cell**, and then press ENTER.![](D:\20480C\Allfiles\Mod06\Democode\pic06.png)
22.	To view the new layout, switch to Microsoft Edge. The application displays the **div** elements in a horizontal table. ![](D:\20480C\Allfiles\Mod06\Democode\pic07.png)

#### Switch between positioning modes in a webpage

1. In the F12 Developer Tools window, on the **CSS** tab, clear the three check boxes next to the display attributes for **body**, **article**, and **div**.![](D:\20480C\Allfiles\Mod06\Democode\pic09.png)

   

2. Right-click the **div** entry, and then select **Add rule**.

3. Type **#three**, and then press **Tab**.

>**Note**: This action creates a new rule for the **&lt;div&gt;** element with the **id** property set to **three**. This is the **&lt;div&gt;** containing the text **Three**.

4.	Type **position: relative**, and then press ENTER.![](D:\20480C\Allfiles\Mod06\Democode\pic10.png)
5.	Right-click the **#three** entry, and then select **Add property**.
6.	Type **top: 2em**, and then press ENTER.
7.	Right-click the **#three** entry, and then select **Add property**.
8.	Type **left: 2em**, and then press ENTER.
9.	In Microsoft Edge, notice how the application positions the **three** box relative to its normal position.
10.	In the F12 Developer Tools window, on the **CSS** tab, click the **position:relative** rule for the **#three** selector, change it to **position:absolute**, and then press ENTER. ![](D:\20480C\Allfiles\Mod06\Democode\pic11.png)
11.	In Microsoft Edge, notice how the application positions the **three** box relative to its containing **article** block.
12.	In the F12 Developer Tools window, on the **CSS** tab, click the **position:absolute** rule for the **#three** selector, change it to **position:fixed**, and then press ENTER.![](D:\20480C\Allfiles\Mod06\Democode\pic12.png)
13.	In Microsoft Edge, notice how the application positions the **three** box relative to the browser window. Make the window small enough to require scrolling and see how the **three** box remains stationary when you scroll (it does not scroll into view).
14.	Close Microsoft Edge.
15.	Close **positioning.html - Microsoft Visual Studio**. 