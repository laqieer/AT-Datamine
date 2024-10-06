-- このluaスクリプトは、CO_101064_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030002")

	change_face(Actor002,"Smile")

	--★★リアム★★:おや、ノワールさん<br>まだいらしたんですね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030003")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:あー、いや<br>ちょっとリアムさんに聞きたいことがあって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030004")

	change_face(Actor002,"Normal")

	--★★リアム★★:私に…？<br>なんでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさん、ちょっと前に酒場の裏あたりで<br>酔っ払いとケンカしてなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030006")

	change_face(Actor002,"Surprise")

	--★★リアム★★:は？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:俺、現場の前を通りがかってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そのときに聞こえた声が<br>リアムさんとよく似ていたな～、って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あの…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030013")

	change_face(Actor002,"Smile")

	--★★リアム★★:ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030015")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:お近づきの印として、これを差し上げます<br>鉢に植え替えたばかりのハーブです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030018")


	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030019")


	--★★リアム★★:このハーブの香りは<br>心を落ち着かせる効果があります
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:雑念を消したいときにうってつけですよ<br>ぜひ育ててみてください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030021")


	--★★リアム★★:ぜひ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030024")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あっ、ハイ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030026")


	--★★リアム★★:それでは、私はこれで
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030028")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:そうそう。そのハーブ、希少なものですので<br>大事に扱ってくださいね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_02030030")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:み、身動きできなかった<br>あの威圧感…司祭というよりも、まるで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030032")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まさか、な<br>俺の思い違いだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:せっかくもらったし<br>このハーブ、部屋で育ててみるか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_02030036")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
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
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
