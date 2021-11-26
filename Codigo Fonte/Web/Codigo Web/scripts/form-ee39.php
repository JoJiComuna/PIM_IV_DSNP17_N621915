<?php

require_once('FormProcessor.php');

$form = array(
    'subject' => 'New Form Submission',
    'email_message' => 'You have a new form submission',
    'success_redirect' => '',
    'sendIpAddress' => true,
    'email' => array(
    'from' => '',
    'to' => ''
    ),
    'fields' => array(
    'name' => array(
    'order' => 1,
    'type' => 'string',
    'label' => 'COLOQUE SEU NOME',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU NOME\' is required.'
    )
    ),
    'name-1' => array(
    'order' => 2,
    'type' => 'string',
    'label' => 'COLOQUE SEU DOCUMENTO',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU DOCUMENTO\' is required.'
    )
    ),
    'phone' => array(
    'order' => 3,
    'type' => 'tel',
    'label' => 'COLOQUE SEU CELULAR',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU CELULAR\' is required.'
    )
    ),
    'email' => array(
    'order' => 4,
    'type' => 'email',
    'label' => 'COLOQUE SEU EMAIL',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU EMAIL\' is required.'
    )
    ),
    'address' => array(
    'order' => 5,
    'type' => 'string',
    'label' => 'COLOQUE SUA CIDADE',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SUA CIDADE\' is required.'
    )
    ),
    'address-2' => array(
    'order' => 6,
    'type' => 'string',
    'label' => 'COLOQUE SEU ESTADO(SIGLA)',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU ESTADO(SIGLA)\' is required.'
    )
    ),
    'address-1' => array(
    'order' => 7,
    'type' => 'string',
    'label' => 'COLOQUE SEU BAIRRO',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU BAIRRO\' is required.'
    )
    ),
    'address-4' => array(
    'order' => 8,
    'type' => 'string',
    'label' => 'COLOQUE SUA RUA',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SUA RUA\' is required.'
    )
    ),
    'address-3' => array(
    'order' => 9,
    'type' => 'string',
    'label' => 'COLOQUE O NÚMERO DA SUA CASA',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE O NÚMERO DA SUA CASA\' is required.'
    )
    ),
    'address-5' => array(
    'order' => 10,
    'type' => 'string',
    'label' => 'COLOQUE SEU CEP',
    'required' => true,
    'errors' => array(
    'required' => 'Field \'COLOQUE SEU CEP\' is required.'
    )
    ),
    )
    );

    $processor = new FormProcessor();
    $processor->process($form);

    ?>