#ifndef REGISTDIALOG_H
#define REGISTDIALOG_H

#include <QDialog>

namespace Ui {
class RegistDialog;
}

class RegistDialog : public QDialog
{
    Q_OBJECT

public:
    explicit RegistDialog(QWidget *parent = 0);
    ~RegistDialog();

private slots:
    void on_sitButton_clicked();

    void on_pushButton_clicked();

private:
    Ui::RegistDialog *ui;
    QImage imageArr[34];
};

#endif // REGISTDIALOG_H
