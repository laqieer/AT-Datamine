-- このluaスクリプトは、CO_101013_0204.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_女1", "笑い")
-- ▲直接出力

	--★★市民（女）★★:本当にありがとうございます
	Talk(Actor004,"NPCNAME_0249","speech","N","CO_101013_02040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:すぐに見つかって良かったぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ガウェインのおかげだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:俺なんかなにもしてねーって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040005")


	--★★ガウェイン★★:このあたりじゃ見かけない子だから<br>印象に残りやすかったんだろうな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040006")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:これからは<br>勝手にいなくなっちゃダメだよ？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02040008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:お母さんに心配かけないようにな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040009")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★子供（男）★★:ごめんなさい…
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:来たばかりの街だから<br>探検でもしてたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★子供（男）★★:虫を探してたの
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040012")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:虫？どんな虫だ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040013")

-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）★★:キンイロチョウってわかる？
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:キンイロチョウ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:うん、そう<br>この島だけにいるすごく珍しい蝶なんだ
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040016")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:なんでその蝶を探してるんだ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040017")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:キンイロチョウはお父さんがお母さんに<br>プロポーズするときに贈ったものなんだ
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040018")


	--★★子供（男）★★:キンイロチョウは仲良しのふたりを<br>キラキラの未来へ連れて行ってくれるんだって
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040019")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("市民_女1", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★市民（女）★★:先日、私たちの住んでいた村が<br>バルバロイに襲われました
	Talk(Actor004,"NPCNAME_0249","speech","N","CO_101013_02040021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★市民（女）★★:たまたま滞在していた男性に私とトムは<br>助けていただいたのですが、夫は…
	Talk(Actor004,"NPCNAME_0249","speech","N","CO_101013_02040022")


	--★★市民（女）★★:家も壊れてしまいましたし<br>私たちは親戚を頼ってこの街へ来たんです
	Talk(Actor004,"NPCNAME_0249","speech","N","CO_101013_02040024")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たまたま滞在していた男性？<br>誰なんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:名前とか聞いてないのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040026")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_女1", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★市民（女）★★:バルバロイを倒したあと<br>名も告げず去られてしまわれました
	Talk(Actor004,"NPCNAME_0249","speech","N","CO_101013_02040027")

-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）★★:背が高くて真っ黒な服の<br>オジサンだった！
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040028")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それだけじゃさすがにわからないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040029")

-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）★★:最初は怖そうって思ったけど<br>話したら優しい人だってすぐにわかったよ
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040030")

	change_face(Actor005,"Smile")

	--★★子供（男）★★:僕がお母さんのそばで泣いてたら<br>優しく頭を撫でてくれたんだ
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_02040033","CO_101013_02040034")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだ、その反応？<br>もしかして心当たりがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040036")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや、どうだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040037")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:でも、やっぱりヒーローは<br>名も告げず去るのがカッコイイなと思ってさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たまたま村を訪れていたのか<br>非番の兵士かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040040")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:うーん、どうだろうな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040041")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんにせよ腕が立つのは間違いない<br>どこに所属している人間なんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040042")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:案外近くにいたりしてな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:そうそう
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02040044")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040045")

	goto Block1end

::Block1end::
	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "落胆")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★子供（男）★★:思い出のキンイロチョウが<br>そばにいてくれれば…
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040047")


	--★★子供（男）★★:ううん。キンイロチョウは、僕たちのなかの<br>お父さんの記憶を守ってくれると思うんだ
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040049")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お父さんの記憶を、守る…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "納得")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:トムは家族想いなんだな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040051")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…よし！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040053")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:じゃあ<br>今度俺たちとキンイロチョウを探しに行くか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040055")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("子供_男2", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★子供（男）★★:本当！？
	Talk(Actor005,"NPCNAME_0248","speech","N","CO_101013_02040056")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ああ、本当さ<br>な、ノワール！ラグネル！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02040057")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん付き合うよ<br>すぐに捕まえてみせるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02040058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:え？<br>う、うん、蝶、蝶ね…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02040059")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（けど、虫捕りか…<br>苦手なんだよな、虫………）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101013_02040060")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
