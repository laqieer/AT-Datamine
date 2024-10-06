-- このluaスクリプトは、CO_101032_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101040","001","101040001")
	Actor007 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor008 = InitializeCharacter_2DOnly("401029","001","401029001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ごちそうさま今日も美味しかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020002")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:おそまつさまだ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガレス★★:ノワールが戻って来てくれてよかった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:あのとき以来学園はずっと空気が重いんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガレス★★:どんなにたくさん料理を振る舞ってもみんなちっとも笑顔になってくれない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020006")

	change_face(Actor002,"Normal")

	--★★ガレス★★:でも、ノワールが戻って来てくれて学園に活気が戻った気がする
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガレス★★:ううん、「気がする」じゃないな間違いなく戻った
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020009")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:ランスロットとギネヴィアが元気になってそのおかげでみんなも元気になったから♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_05020012","CO_101032_05020013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただいま心配させちゃってごめんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガレス★★:ううん<br>謝る必要なんてないぞ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020016")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガレス★★:でも、もういなくならないって約束はしてほしい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:学園を離れているあいだずっとガレスのご飯が食べたかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020019")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ろくなご飯が食べられなかったからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020020")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:励ましてくれてるんだな<br>ありがとう、ノワール！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020021")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("グリフレット", "肯定2")
-- ▲直接出力

	--★★料理人★★:珍しいな、ふたりで来るなんて<br>で、ご注文は？
	Talk(Actor008,"NPCNAME_0260","speech","L","CO_101032_05020023")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ランスロット2D★★:食事をしにきたわけでは…
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","CO_101032_05020024")

	change_face(Actor007,"Normal")

	--★★ランスロット2D★★:いや、いただこうかコーヒーとなにか軽いものを頼む
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","CO_101032_05020025")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ2D★★:私も同じもので
	Talk(Actor006,"CHRNAME_KAY","speech","L","CO_101032_05020026")

-- ▼直接出力
 --ランスロット&ケイ登場
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor005)
Appear(Actor004)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
lookat_weight(Actor005,0.55,0.1,0.8,0.2)
keep_ik_lookat(Actor005,Actor002,"J_Head")
lookat_weight(Actor004,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor004,Actor002,"J_Head")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(4,true)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたんだ、ふたりして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020028")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ガレスに用事があって来た
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020029")

-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:わたしに？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020030")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:アーサーを追ってガウェインもいなくなっただろう？
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101032_05020031")


	--★★ケイ★★:ガレスが無理をしているのではないかと思ってな
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101032_05020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:辛いようならしばらく休暇をとるといい
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガレス★★:ありがとう、ふたりとも
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020034")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:でも、わたしだって円卓の騎士のひとりだぞ？こんなことで音を上げるわけにはいかない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:それに、兄さんが戻ってきたときに<br>わたしがここにいなかったら
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020036")


	--★★ガレス★★:誰がご飯を食べさせてあげるんだ？<br>絶対にお腹ペコペコなはずなのに
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020037")

-- ▼直接出力
PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ランスロット★★:ガレス…
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020038")

-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:心配ならいらないぞ？<br>アシスタントのひとりが戻ってきてくれたしな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_05020041","CO_101032_05020042","CO_101032_05020043")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アシスタント？誰のことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020045")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:この話の流れなら貴公しかいないであろう
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101032_05020046")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:あたしと一緒に<br>ガレスをサポートするんだ、ノワール！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_05020047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ガレスのことなら俺がサポートするだから大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020049")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ほらノワールもこう言ってる♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020050")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:あたしもいるしな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_05020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:そうそうわたしには頼りになるキラーズもいるもの
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020052")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレス、ふたりのいうとおりだ辛いなら無理せず休んだほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020054")

-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガレス★★:ノワールまでそんなことを言うのか…？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020056")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:見損なったぞ、ノワール！あたしたちは三位一体じゃなかったのか！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_05020057")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020058")

	goto Block2end

::Block2end::
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:わかったガレスのことはノワールに任せる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020060")


	--★★ランスロット★★:だが、ガレスもしも辛いと感じたときは無理をするな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020061")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:もしもお前がいなくなっていたりしたら戻ってきたとき、ガウェインが悲しむ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","CO_101032_05020062")

-- ▼直接出力
 --ランスロット＆ケイ退場のため、カメラ固定
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うん、わかった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020063")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor005)
Hide(Actor004)
setup_small_camera_start()
set_enable_auto_lookat(Actor001, true)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力

	--★★ガレス★★:…よし！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020065")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ノワールも戻ってきたことだし兄さんのためのメニュー開発を再開しよう♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020066")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、協力させてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_05020067")

-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:頼りにしてるぞ、ノワール！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_05020068")

-- ▼直接出力
 --ノワール＆リオネス退場のため、カメラ固定
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:また忙しくなるぞ！ふたりは先に帰って英気を養っておいてほしい♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020070")

	change_face(Actor002,"Normal")

	--★★ガレス★★:わたしは後片付けをしてから帰るよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020071")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
lookat_weight_reset(Actor002)
Hide(Actor001)
Hide(Actor003)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガレス★★:本当に、ノワールが戻って来てくれてよかった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_05020073")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101040","001","101040001")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	InitializeCharacter_2DOnly_Preload("401029","001","401029001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
