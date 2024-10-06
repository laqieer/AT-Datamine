-- このluaスクリプトは、CO_101013_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
 keep_ik_lookat(Actor002,Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ほんと、太陽が出てるときの<br>ガウェインは元気だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ノワール、ラグネルの様子を<br>見てもらってていいか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030004")

	open_select_window_tag(Actor001,"Normal","CO_101013_03030006","CO_101013_03030007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかく来たんだし<br>俺も一緒に蝶を探させてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030009")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:手伝ってくれるのはありがたいけどよ<br>お前もそんなに得意じゃないんだろ、虫
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030010")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも、それじゃ<br>トムに合わせる顔がないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:まあ、そうか<br>じゃあ、手伝ってくれ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なんだかんだ言って<br>心配なんだな、ラグネルのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030014")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ガキんときからずっと一緒だからなあ<br>あいつが虫嫌いなの知ってるけど
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030015")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:それ以上に、こういうとき<br>頑張りすぎちゃうヤツってのも知ってる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:自分で言ってやればいいのに<br>「頑張りすぎるな」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:今さら恥ずかしくて言えねーし<br>言って聞くタマでもねーよ、あいつ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうものかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そういうもんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030020")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:しっかし、いねーなあ<br>キンイロチョウ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030022")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:珍しい蝶とは聞いていたけど<br>ここまで見つからないとは思わなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030024")

-- ▼直接出力
setup_small_camera_start(Camera004)
set_enable_auto_lookat(Actor001,false)
keep_ik_lookat(Actor001,Actor004, "J_Head")
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor002,Actor004, "J_Head")
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor003,Actor004, "J_Head")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★子供（男）★★:やっぱり無理なのかなあ…
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:やっぱり？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03030026")

-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:僕ね、キンイロチョウの話を聞いて<br>前にお父さんと捕まえに来たことがあるんだ
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030027")


	--★★子供（男）★★:そのときお父さんは<br>「諦めない心が大事なんだぞ」って
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030028")


	--★★子供（男）★★:僕をずっと励ましながら<br>遅くまで頑張って探してくれたんだけど
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030029")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "落胆")
-- ▲直接出力

	--★★子供（男）★★:…結局見つからなかった
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030030")


	--★★子供（男）★★:しかも<br>僕は疲れて途中で眠っちゃってね
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★子供（男）★★:気付いたらお父さんの背中にいたんだ
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030032")

-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:それで僕が「ごめんね」って言ったら<br>「キンイロチョウ、捕れなくてごめんな」って…
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030033")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:優しい親父さんだったんだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★子供（男）★★:うん<br>お父さんの声を聴くと、いつも元気になれた
	Talk(Actor004,"NPCNAME_0248","speech","N","CO_101013_03030036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そっか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030037")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:うっし！もうひと頑張りすっか！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030038")


	--★★ガウェイン★★:子供（男）の親父さんも「諦めない心が大事」って言ってるしな！ 
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03030039")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ3_4")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
