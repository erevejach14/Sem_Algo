#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "registdialog.h"

#include "pasanjersflightview.h"

#include <list>
#include <string>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private slots:
    void on_registButton_clicked();

    void on_seeFights_clicked();

private:
    Ui::MainWindow *ui;
    RegistDialog regist;

    PasanjersFlightView viewP;
    
    int id;
    int num;
    std::string cad;
};

#endif // MAINWINDOW_H
