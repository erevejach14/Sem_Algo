/*#ifndef TRAFFICLIGHT_H
#define TRAFFICLIGHT_H

#endif // TRAFFICLIGHT_H
*/

#ifndef TRAFFICLIGHT_H
#define TRAFFICLIGHT_H
#include "trafficpic.h"

#include <QWidget>
#include <QTimer>
#include <QLabel>
#include <QLineEdit>
#include <QPushButton>

class TrafficLight: public QWidget{
    Q_OBJECT
public:
    //constructor
    TrafficLight();

private slots:
    //set timer
    void setTimer();
    //display image
    void displayImage();
    //cancel timer
    void cancelTimer();

private:
    //widget data members
    QLabel* timerLabel;
    QLineEdit* timerEdit;
    QPushButton* okButton;
    QPushButton* cancelButton;
    QImage* image;
    //timer
    QTimer* timer;
    //instance of image
    TrafficPic tf;
    //sets up the GUI and connects signals and slots
    void setUpGUI();
};

#endif // TRAFFICLIGHT_H
