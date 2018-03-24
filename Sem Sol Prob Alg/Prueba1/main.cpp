#include <QApplication>
#include "trafficlight.h"

int main(int argc, char *argv[]){
    QApplication a(argc, argv);
    TrafficLight tl;
    tl.show();
    return a.exec();
}
