#include "registdialog.h"
#include "ui_registdialog.h"

RegistDialog::RegistDialog(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::RegistDialog)
{
    ui->setupUi(this);
    for(int i = 0; i < 10;i++){
        std::string labelName;
        labelName = "A" + i;
        QImage imageArr[34] = new QImage(this);

    }
}

RegistDialog::~RegistDialog()
{
    delete ui;
}

void RegistDialog::on_sitButton_clicked()
{
    //selectedSit.text
}

void RegistDialog::on_pushButton_clicked()
{
    this->close();
}
