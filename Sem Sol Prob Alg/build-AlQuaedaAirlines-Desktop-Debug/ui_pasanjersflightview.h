/********************************************************************************
** Form generated from reading UI file 'pasanjersflightview.ui'
**
** Created by: Qt User Interface Compiler version 5.7.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_PASANJERSFLIGHTVIEW_H
#define UI_PASANJERSFLIGHTVIEW_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QColumnView>
#include <QtWidgets/QDialog>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QPushButton>

QT_BEGIN_NAMESPACE

class Ui_PasanjersFlightView
{
public:
    QColumnView *columnView;
    QPushButton *return_2;
    QPushButton *pushButton;

    void setupUi(QDialog *PasanjersFlightView)
    {
        if (PasanjersFlightView->objectName().isEmpty())
            PasanjersFlightView->setObjectName(QStringLiteral("PasanjersFlightView"));
        PasanjersFlightView->resize(400, 300);
        columnView = new QColumnView(PasanjersFlightView);
        columnView->setObjectName(QStringLiteral("columnView"));
        columnView->setGeometry(QRect(100, 60, 256, 192));
        columnView->setStyleSheet(QStringLiteral(""));
        return_2 = new QPushButton(PasanjersFlightView);
        return_2->setObjectName(QStringLiteral("return_2"));
        return_2->setGeometry(QRect(10, 220, 80, 25));
        pushButton = new QPushButton(PasanjersFlightView);
        pushButton->setObjectName(QStringLiteral("pushButton"));
        pushButton->setGeometry(QRect(10, 180, 80, 25));

        retranslateUi(PasanjersFlightView);

        QMetaObject::connectSlotsByName(PasanjersFlightView);
    } // setupUi

    void retranslateUi(QDialog *PasanjersFlightView)
    {
        PasanjersFlightView->setWindowTitle(QApplication::translate("PasanjersFlightView", "Dialog", 0));
        return_2->setText(QApplication::translate("PasanjersFlightView", "regresar", 0));
        pushButton->setText(QApplication::translate("PasanjersFlightView", "Eliminar", 0));
    } // retranslateUi

};

namespace Ui {
    class PasanjersFlightView: public Ui_PasanjersFlightView {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_PASANJERSFLIGHTVIEW_H
