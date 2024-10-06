-- このluaスクリプトは、CO_101030_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor002)
set_pos(Actor001,CharaPosDuelCommonFormation01_105)
set_pos(Actor002,CharaPosDuelCommonFormation01_106)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_RUN_2P(Actor001,CharaPosDuelCommonFormation01_005,Actor002,CharaPosDuelCommonFormation01_006)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:まだあまり遠くには行っていないと思うけれど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030002")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:無事でいてくれよ、トビー！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:私のせいでしょうか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030004")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-10,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★エレイン★★:私がお父さんが生きているといったせいでトビーくんはロンディニウムに…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_08030007","CO_101030_08030008","CO_101030_08030009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレインが気に病む必要はないよトビーはキミに懐いていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キミの言葉とキミが運んでくる友達の手紙が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:トビーの心を癒していたことは間違いない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030013")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ありがとうございます…でも、トビーくんは出て行ってしまった
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…かもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そう、ですよね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★エレイン★★:私は大馬鹿だ…トビーくんの心を傷つけて今度は命の危険に遭わせようとしている…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今は誰が悪いとか考えている場合じゃない一刻も早くトビーをさがさないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:手分けしてさがしたほうがいいかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:わ、わかりましたトビーくん、無事でいて…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030022")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★エレイン★★:私、かわりたかったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:いつもオドオドお兄ちゃんの背中に隠れる自分とお別れしよう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:人の目を見て堂々と話そうみんなを引っ張っていける人間になろう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030026")


	--★★エレイン★★:先輩やギネヴィアさんと出会ってかわれている気がしていました…少しずつ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:でも、そう思っていたのは私だけなのかもしれません
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_08030030","CO_101030_08030031","CO_101030_08030032")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エレインはかわったじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030034")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺やラヴェイン以外とも手紙を介さずに話せるようになったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030035")

-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:それは先輩たちのおかげですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030036")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:学園祭だってこのあいだのスノードン山の戦いだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミがみんなを引っ張ってくれたから成功したんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030038")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
change_face(Actor002,"Shy")
PlayActionDirect(Actor002,"to  Std_Sad01")
wait_time(2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2)
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかに、出会ったときからあまりかわったようには思えないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030040")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そう…ですよね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030041")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや！それは見た目の話であって…あっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030042")

	change_face(Actor002,"Sad")

	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030043")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめんそんなつもりじゃなかったんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030044")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:無理にかわろうとしなくてもいいんじゃないか？キミはキミのままで十分魅力的だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:いえ、それじゃダメなんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030047")

	change_face(Actor002,"Sad")

	--★★エレイン★★:お兄ちゃんのためにアストラットに暮らすみなさんのために
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030048")

	change_face(Actor002,"Sad")

	--★★エレイン★★:私は、かわらないと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030049")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:心を閉ざしてしまいそうなトビーくんを見て思ったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030051")


	--★★エレイン★★:あのときのお兄ちゃんのようにまずは手紙で元気づけてあげよう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030052")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:先輩やギネヴィアさんのように手を差し伸べてあげようって
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:みんなに救われた私だから今度はかわりにみんなを救ってあげたい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08030054")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…そうかきっとかわれるよ、キミなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08030055")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
CloseTalkWindow()
wait_time(1.7)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Normal")

	--★★エレイン★★:あっ！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","CO_101030_08030056")

	close_cutin()
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ8_4")
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
