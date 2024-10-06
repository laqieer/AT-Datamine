-- このluaスクリプトは、CO_101032_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",340,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",240,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.5)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…料理の手伝いじゃなかったっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020002")


	--★★ガレス★★:新しい料理、新しい味のためには新しい食材が必要だと思うんだよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020003")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:だからみんなで新しい食材を探そう～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020004")

	open_select_window_tag(Actor001,"Normal","CO_101032_02020006","CO_101032_02020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だからってわざわざこんな森の奥まで来る必要あるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:ありきたりな場所に行ったってありきたりな食材しか見つからないよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはまぁ、確かに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気分転換にもなりそうだなピクニックみたいでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:最近のガレスはキッチンに籠もりっぱなしだったからな
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02020014")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:キッチンで浮かぶアイデアには限界があるかもって思ったんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020015")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:だから１度外に飛び出してみることにした！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020016")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:視点を変えるのは大事だな俺も力になれるよう頑張るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020017")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでさどんな食材を探すかは決めてあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:山菜だ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020020")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガレス★★:兄さん、山菜をぜんぜん食べないんだ苦いとかヌメヌメしてるからイヤだって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:山菜には野菜や肉から摂れない栄養も多いのに！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020022")

	change_face(Actor002,"Normal")

	--★★ガレス★★:実は食べやすいように調理して出したこともあるんだけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:全部どかされちゃった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_02020026","CO_101032_02020027","CO_101032_02020028")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェイン以外の知り合いでも山菜が苦手なヤツって多い気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020030")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:ええええーっ！？好き嫌いはよくない！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020031")

	change_face(Actor002,"Normal")

	--★★ガレス★★:いいメニューが見つかったら食堂でも出してみんなに食べさせることにしよう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020032")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もったいない美味しい山菜はたくさんあるのにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020034")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:そうだろう！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020035")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:傭兵時代は山や森に入ることが多かったからよく食べたもんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020036")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ガレス★★:帰ったらノワールからも兄さんに言ってやってくれ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020037")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところで…リオネス、なんか静かじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020039")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:えっ！？ぜ、ぜんぜん静かじゃないぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02020040")

	change_face(Actor003,"Sad")

	--★★リオネス★★:山菜は嫌いじゃないけどお腹にたまらないからな～なんて思ってない！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02020041")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふーん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020043")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃ、お腹いっぱいになるくらいたくさん集めるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02020044")

	goto Block2end

::Block2end::
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ってことで山菜をたくさん集めるぞ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020046")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:ワラビ、ゼンマイ、フキノトーッ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02020047")

-- ▼直接出力
 --暗転＆時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_enable_auto_lookat(Actor002, false)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
change_face(Actor001,"Normal")
change_face(Actor002,"Sad")
change_face(Actor003,"Normal")
setup_small_camera_start(Camera002)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:うーん…たくさん集まったのはいいけどどれも見たことのあるものばっかりだな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020049")

-- ▼直接出力
 --村人登場のため、カメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:ガウェイン、食べてくれるかな、これ？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02020050")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
Appear(Actor005)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★市民（男）②★★:おや、山菜を採りに来たのかい？
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101032_02020052")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.5)
wait_time(0.2)
keep_ik_lookat(Actor003,Actor005,"J_Head")
lookat_delay_weight(Actor003,0.5,0.1,0.8,0.2,1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うん山菜が苦手な知り合いがいて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020053")


	--★★ガレス★★:その人にも食べられそうなものがないか探しに来たんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020054")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "喜び")
-- ▲直接出力

	--★★市民（男）②★★:ははは山菜が苦手か、そういう子は確かに多いね
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101032_02020055")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:ぼくもきらいだったーにがいし、ぬめぬめしてるし
	Talk(Actor005,"NPCNAME_0077","speech","N","CO_101032_02020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:…だった？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020057")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:うんでも、いまはたべられるよ
	Talk(Actor005,"NPCNAME_0077","speech","N","CO_101032_02020058")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:この森に美味しい山菜が生えているのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "悩む")
-- ▲直接出力

	--★★市民（男）②★★:あなたたちが採ってきた山菜がこの森で採れるすべてだと思いますよ
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101032_02020060")


	--★★市民（男）②★★:山菜嫌いの子供（男）②でも食べられるようになる特別な食べかたがあるんです
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101032_02020061")


	--★★ガレス★★:本当か！？よかったら教えてほしい！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020062")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★市民（男）②★★:この木の実を使うんですよ
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101032_02020063")

	change_face(Actor002,"Normal")

	--★★ガレス★★:なるほどなー<br>よし、学園の食堂に戻って作ってみよう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020065")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ふたりとも、ありがとう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02020066")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ2_3")
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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
