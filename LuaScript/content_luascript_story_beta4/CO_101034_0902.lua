-- このluaスクリプトは、CO_101034_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_03","110071_03_h")
Include("content_adv_advsmall_110071_03","Template110071_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",40,CharaPos110071_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_03,CameraPos110071_03_003)
	InitializeTemplateRandomCamera110071_03()
	InitializeTemplate110071_03()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor002,{3.7,0.13,18.5})
set_rot(Actor002,{0,160,0})
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:気を遣わせてしまったみたいねありがとう、ノワール
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:よかったら、聞いてくれる？このあいだの話の続き
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020004")

	open_select_window_tag(Actor001,"Normal","CO_101034_09020006","CO_101034_09020007","CO_101034_09020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聞かせてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020010")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:そんなにかしこまった態度をされると緊張しちゃうわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はぐらかさないでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020012")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:…ごめんなさい
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いいのか？俺なんかに聞かせてくれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ええあなたに聞いてほしいの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったぜひ聞かせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？まだ心の準備ができていない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020019")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そうそれならいいわ。さようなら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020020")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちょ、ちょっと待って！冗談だよ冗談
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020021")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:………
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
turn_chara(Actor002,104,0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:私、とある研究施設にいたの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020024")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いったいなにを研究していた施設なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020025")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:わからない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020026")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:いいえ、今ならなんとなくわかるわ兵器…武器、というのが正しいかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:毎日のように見たこともない薬を飲まされ体液を取られ、身体を調べられた
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020030")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:施設に入れられる前の記憶はない施設にいたときの記憶もあまりないけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020031")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020032")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうやってその施設の外に出たんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020033")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:あるとき施設内に怒声と悲鳴とが響き渡った
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020034")


	--★★エクセリア★★:そしてそれはなにかが爆発したような轟音を境に<br>ぴたりと止んだの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020035")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:私は走ったわ風の吹いてくる方向を目指して
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★エクセリア★★:逃げたかったか、怖かったか、嬉しかったかそのときの感情は覚えていない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020037")


	--★★エクセリア★★:どれだけ走ったかも覚えていないけれど私は走って走って、走り続けて…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020038")


	--★★エクセリア★★:いつの間に眠ってしまった
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:そして目覚めたとき私はアダンに背負われていた
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:あのときの声の優しさと背中の広さは今でも忘れないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020041")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:アダンがキミを助けてくれたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020042")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,160,0.5)
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ええ。でも…ふふっこの続きは笑わないって約束してくれる？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020044")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:その頃の私は記憶だけでなく<br>常識もなくてね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:空腹に耐えられなくなってそのあたりに生えている草を食べたの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_09020048","CO_101034_09020049","CO_101034_09020050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アダンもそれはビックリしただろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:えぇ、最初はなにをしているのか飲み込めていなかったわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020053")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:しばらくして我に返ったアダンに全力で止められたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そりゃそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どんな味だった？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020057")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:さあ？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020058")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そのときは「おいしい」だとか「まずい」なんて感覚は持ち合わせていなかったと思う
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020059")

	change_face(Actor002,"Surprise")

	--★★エクセリア★★:あっ。今は大丈夫よ？五味はちゃんと理解してる
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020060")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、それを聞いて安心したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020061")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:食べられる野草ってのも珍しくないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020063")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:私も花について調べているうちにそのことを知ったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020064")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:昔の私がこのことを知っていたらとても役に立ったと思う
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020065")

	change_face(Actor001,"Normal")

	--★★ノワール★★:食べられる草だけを食べれたのにって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:そうすればアダンも驚かなかったかも
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020067")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、草を食べてることに変わりはないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020069")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ふふっ、たしかにね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020071")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Worry")
turn_chara(Actor002,104,0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そのあと私はアダンとコルベニック城に行きそこで色々なことを教わった
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020073")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エクセリア★★:「少しずつ普通になっていけばいいんだ」ってこともね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020075")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:少しずつ普通になっていけばいい、か素敵な言葉だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020076")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:私には記憶がない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020078")


	--★★エクセリア★★:でも、だからこそみんなが持っている記憶の大切さを理解している
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020079")


	--★★エクセリア★★:みんなの記憶を守ってあげたいのアダンとともに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:あなたたちとともに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020081")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ<br>…ああ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020083")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エクセリア★★:たとえ聖遺物化してみんなが私のことを忘れてしまうとしてもね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020084")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は忘れないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020085")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,160,1)
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:えっ？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:勿忘草このあいだお墓に供えただろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020087")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:えぇ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020088")

-- ▼直接出力
PlayActionDirect(Actor001,"to LookFor")
-- ▲直接出力

	--★★ノワール★★:勿忘草の花言葉を調べたんだ「私を忘れないで」なんだってな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020089")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Show")
-- ▲直接出力

	--★★ノワール★★:これ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020091")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:花の種？なんの花？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020092")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:俺は憶えておくから、エクセリアのことだからそんな顔するな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020094")


	--★★エクセリア★★:俺は覚えておくって…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020095")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:決めたからなにがあってもキミのことを覚えておくって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_09020097")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(2)
change_face(Actor002,"Smile")
wait_time(2)
setup_small_camera_start(RndCamera007)
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:あなたを信じるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_09020099")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
