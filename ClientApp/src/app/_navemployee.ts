export const navItemsEmp = [
    {
        title: true,
        name: 'Reports'
    },
    {
        name: 'Payroll',
        url: '/reports',
        icon: 'fa fa-file-pdf-o',
        children: [
            {
                name: 'Payroll Period',
                url: '/reports',
                icon: 'fa fa-money'
            }
        ]
    },
    {
        title: true,
        name: 'Loans'
    },
    {
        name: 'Loan Balance',
        url: '/loans',
        icon: 'fa fa-balance-scale'
    }
];
