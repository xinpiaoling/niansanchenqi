//ʹ��setTimeout()������setInterval()��ʵ��ÿ��1����������ʾ����n�ܣ�Դջͬѧrandom�ˡ���n��ε�����random�����
//��������
//��5�ܣ�Դջͬѧ541�ˣ�
//��ȷ����
//��������Ϊ1-48�����ڰ�����48�ܣ�
//����Ҫ��Ϊ��������
//��������Ϊ0-1000������,����



//var counter = 1;
//function greet() {
//    if( counter< 49) {
//        var k = Math.ceil(Math.random() * 1000 + 1);
//        setTimeout(function () {
//            console.log('��' + counter + '�ܣ�Դջͬѧ' + k/*Math.ceil(Math.random() * 1000) */ + '��');
//            counter++;
//            greet();
//        }, 1000);
        
//    }

//}

//greet();



//��ɲ����ֵ���Ϸ��
//������Ϸ�淨˵�����ȴ��û������ȷ�ϡ�����ʼ��Ϸ��
//���������һ��������1000�������������
//�û�����²⣻
//����û�û�в¶ԣ�������ȽϺ��֪����������ˡ����ߡ�С�ˡ�������û���
//ֻ���˲���6�ξͲµ����������ﱤ�ˣ�
//ֻ���˲���8�ξͲµ���������666��
//����8 - 10�βµ����������µ��ˡ�
//����10�ζ���û�¶ԣ�������^ (*��(oo) ��)^

//��������
//


var gameNumber = Math.ceil(Math.random() * 1000);

//if (confirm('��Ϸ����')) {
    for (var i = 1; i < 11; i++) {
        var word = prompt('');
        if (isNaN(word)) {
            alert('������Ĳ���һ������,������һ��������');
            continue;
        }
        if (word < 0) {
            alert('������Ĳ���һ����������������һ��������');
            continue;
        }
        if (!(word.indexOf('.') === -1)) {
            alert('������Ĳ���һ����������������������');
            continue;
        }
        if (word === gameNumber) {
            if (i < 6) {
                alert('�ﱤ��');

            } else if (i < 8) {
                alert('666');

            } else if (i < 10) {
                alert('�µ���');
            }

        }

        else {
            if (i < 10) {
                if (word < gameNumber) {
                    alert('С��');

                } else {
                    alert('����');
                }

            } else {
                alert('^ (*��(oo) ��)^');
            }

        }

    }

//}















