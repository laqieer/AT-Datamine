-- このluaスクリプトは、CO_101030_0304.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あの、さ。触れられたくないなら無理に話してくれなくていいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040002")


	--★★ノワール★★:『アストラットの美姫』って呼ばれるの好きじゃないみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…気づかれちゃいましたか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040004")


	--★★エレイン★★:代々、アストラットの領主の家に生まれた女性は大きな偉業をなし遂げてきました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040005")


	--★★エレイン★★:私の母はアストラットとログレスとの関係を強固なものにしましたし
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:祖母は近隣の人々をまとめあげアストラットを築いた、初代の領主です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040007")


	--★★エレイン★★:だから、私が産まれたとき…両親だけでなく村中が喜んだと聞いています
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:「新たな美姫の誕生だ」と
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0025")
-- ▲直接出力

	--★★エレイン★★:でも…私はなにをやっても兄たちにかないませんでした
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040011")


	--★★エレイン★★:みんなの期待に応えられなかったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040013")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン★★:私は徒花見る価値のない、期待する価値のない存在です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_03040016","CO_101030_03040017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そんなに自分を卑下する必要はないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エレインは強い女の子だしみんなからの期待にも応えられてると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040020")

-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そう、でしょうか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんとなくだけど、わかるよ俺も『継承者』なんて持ち上げられてるしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「なんで俺が？」「逃げてしまいたい」何度もそう思った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040024")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:でも、周りのみんなが支えてくれたから今こうしていられる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040025")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺もキミを支えるからどんな結果が待っていようと前を向いていこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040026")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:自分のことを見てくれている人の目をまっすぐ見つめ返してみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101030_sp_0001_3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩…ありがとうございます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040028")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Sad01")
wait_time(2)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:トビーくん良くなってくれるといいんですけど…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040030")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:きっとすぐ良くなるさあとで様子を見に来てやろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03040031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03040033")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
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
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
