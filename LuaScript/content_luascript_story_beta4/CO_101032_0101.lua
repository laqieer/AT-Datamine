-- このluaスクリプトは、CO_101032_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera003 = SetTemplate("Actor003",150,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_007)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.08,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.4,0.08,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.4,0.08,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera004 = SetTemplate("Actor004",213.9075,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera005 = SetTemplate("Actor005",92.60517,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_pos(Actor005,{-3.646,0,-13.216})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ん～、今日もいい匂いがしてるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010002")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("グリフレット", "挨拶")
-- ▲直接出力

	--★★料理人★★:う～っす
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010003")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:あ、ノワール！ちょうどいいところにきたな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:きみ、お腹空いてないか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょうどペコペコでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010007")


	--★★ノワール★★:すぐ出せる料理でいいんでなにか食べさせてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010008")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("リオネス", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★リオネス★★:ノ、ノワール…バトンタッチだ…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:リオネス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010011")

	change_face(Actor003,"Sad")

	--★★リオネス★★:も、もう食べられない…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor004, true)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:オリジナルのコース料理を考えててね試作品をリオネスに食べてもらってたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010013")

-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力

	--★★リオネス★★:さ、さすがのリオネス様でもコース料理周回はキツいぞ…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010014")

	open_select_window_tag(Actor001,"Normal","CO_101032_01010016","CO_101032_01010017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:OK。リオネス、バトンタッチしようガレスの新作料理を食べられるなんてラッキーだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010019")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:ノワール、心の友よ～おまえならそう言ってくれると信じてたぞ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よ～し、これでもっと色んな料理を試せるぞ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010022")

	change_face(Actor001,"Smile")

	--★★ノワール★★:さあ、ドンドン持ってきてくれ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("リオネス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★リオネス★★:ノワール…あたしはもうダメだ…あとを、頼む…ガクッ…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:パスしとく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010026")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:えええ～っ！？付き合い悪いぞ、おまえー！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リオネスがギブアップするほどの量を俺には食べられないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010028")

-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:食べられるかぎりでいいから！ねっ、お願いだよノワール！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010029")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ううーん…そこまで言われたら、しょうがないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010030")

	goto Block1end

::Block1end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
template2()
setup_small_camera_start()
set_pos(Actor004,{1.892,0,-10.358})
set_pos(Actor005,{-3.646,0,-13.216})
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor003,"J_Head")
lookat_weight(Actor004,0.4,0.08,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(5,true)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:どうだ？うまいか？遠慮なく感想を言ってくれ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どれもこれもすごくおいしいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010034")

-- ▼直接出力
CloseTalkWindow()
--setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:だよな！ガレスの料理は世界一だ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★料理人★★:俺の料理は？
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010036")

-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:うっ！？<br>こ、コック長の料理も世界一だ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010037")

-- ▼直接出力
PlayPartVoice("グリフレット", "笑い")
-- ▲直接出力

	--★★料理人★★:世界一がふたりいんのかよ
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,-0.273,0,-13.321,2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,0,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:ああ～、今日もよく頑張ったぜハラ減った～
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010040")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:おっ、ウマそうなモン食ってんな一口もらっていいか？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010042")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:えーっとじゃあ、この山菜の入ってないヤツを…
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:兄さん、好き嫌いはダメだいつも言ってるだろう？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010044")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力

	--★★ガウェイン★★:…うん、まあまあいつもどおりだな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010046")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_01010048","CO_101032_01010049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかにまあまあだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010051")

-- ▼直接出力
PlayPartVoice("リオネス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:ノワール！？さっきは「すごくおいしい」って言ってたろ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010052")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:まあまあ、か…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010053")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあまあってことはないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010055")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレスの料理は手が込んでいていつだって美味い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010056")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ノワール、ありがとう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010057")

	change_face(Actor005,"Sad")

	--★★ガウェイン★★:手が込んでいる、ねえ…
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010058")

	goto Block2end

::Block2end::
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:勘違いすんな？美味いかマズいかでいったら、もちろん美味いよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010060")


	--★★ガウェイン★★:でもなあ、なんていうかガレスの料理って
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010061")

	PlayAction(Actor005,"to  Std_Worry")

	--★★ガウェイン★★:「なんか物足りねえ」って感じるときがときどきあんだよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:小手先の技で誤魔化してるっつーかさ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010063")

	PlayAction(Actor005,"to Greet_one")
	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:じゃ、じゃあハラいっぱいになったし俺は帰るわ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","CO_101032_01010065")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor005)
setup_small_camera_start()
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★料理人★★:あいつ…
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010067")

-- ▼直接出力
PlayPartVoice("グリフレット", "肯定")
-- ▲直接出力

	--★★料理人★★:ガレス、気にすんなよ？
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010068")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:そうだぞ！ガレスの料理は世界一なんだからな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010069")

-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:兄さんはいつもひとことうるさいんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ガレス★★:でも…燃えてきた！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010071")

	change_face(Actor001,"Normal")

	--★★ノワール★★:燃えてきた？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010072")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:兄さんを満足させる料理を作ってやる！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010073")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")

	--★★ガレス★★:「美味い！このあいだはごめんなさい！」って謝らせてやるんだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010074")

-- ▼直接出力
PlayPartVoice("グリフレット", "肯定2")
-- ▲直接出力

	--★★料理人★★:おうおう、その意気その意気！
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_01010075")

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:だからお手伝いをよろしく頼むぞリオネス、ノワール！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010076")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:よろしく頼まれた！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_01010077")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺も！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010078")

	change_face(Actor002,"Smile")

	--★★ガレス★★:味見役は多いほうがいいからな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010079")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:なんか面倒なことになっちゃったけど…わかった、手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_01010080")

	change_face(Actor002,"Normal")

	--★★ガレス★★:わたしはだいたいここにいるから手の空いたときに声をかけてほしい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010081")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:新作料理のアイデアが浮かんだら手伝いをお願いさせてもらうよ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_01010082")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_acquired("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
