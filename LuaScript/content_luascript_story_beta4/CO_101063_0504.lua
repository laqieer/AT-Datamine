-- このluaスクリプトは、CO_101063_0504.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:確かに部屋のどこにも見当たらなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05040002")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ほんとにごめんなさい弁償しますので家族の命だけは…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05040003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:弁償できる、できないの問題じゃないの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040004")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★クリスティーナ★★:あなたが失くしてしまったものと<br>同じ内容の本は確かにあるわ。でもね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★クリスティーナ★★:誰がその本を手に取り、内容になにを感じたか読者の想いを受けて、本は育っていくの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040007")


	--★★クリスティーナ★★:書かれている内容が一緒でもすべてが同じわけじゃない
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:「たかが本を１冊なくしただけだ」あなたはそう思っているかもしれないけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040009")


	--★★クリスティーナ★★:あなたはあの本に込められたたくさんの想い出を消してしまうかもしれない
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040010")

-- ▼直接出力
setup_small_camera_end(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:…ごめん、なさい…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05040011")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:弁償はしなくていいわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:その代わりになにか他の本を読みなさいそして、読んで感じた想いを一生大切にするのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:…はい、わかりましたでも、それとは別に、俺…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05040015")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）★★:あの本をもっと探してみます！この街、いやこの島全体を！
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05040016")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
--keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor002, true)
setup_small_camera_start(RndCamera001)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力

	--★★クリスティーナ★★:あらあら、あんなに急がなくてもいいのに
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040018")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_05040020","CO_101063_05040021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クリスさんへの誤解が解けたんだよ怖い人じゃないってわかってくれたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05040023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:やっぱたまに、はしたないとこあるから？みんなそう思ってたらショックだわ…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040024")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クリスさんの優しさがみんなに伝わればいいんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05040025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:クリスさんが本を大切にしている想いがあいつにも伝わったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05040027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:見つかるといいな、あの本
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05040028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:きっと見つかるわよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040029")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:あのコが向き合ってくれることがわかったなら本のほうから出てきてくれるわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05040030")

	goto Block1end

::Block1end::
-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
