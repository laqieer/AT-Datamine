-- このluaスクリプトは、CO_101064_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:はぁ、あれで最後か…<br>ひとの話を聞くだけでも疲れるもんなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030002")


	--★★ノワール★★:こんなのをリアムさんたちは<br>毎日やってるのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030003")

	PlayAction(Actor002,"to Greet_one")

	--★★クラリス★★:お疲れ様です～ノワールくん～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030005")

	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、クラリス、お疲れ様<br>ひとまず全員の話を聞いておいたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030006")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クラリス★★:ありがとうございます～<br>それじゃ～ハーブのお勉強をしましょうか～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030007")

	change_face(Actor002,"Normal")

	--★★クラリス★★:お手伝いが終わったら<br>ハーブのお世話のしかたを教えてあげなさいと
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030008")


	--★★クラリス★★:リアム様に言われてるんです～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030009")

	open_select_window_tag(Actor001,"Normal","CO_101064_03030011","CO_101064_03030012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>自分の仕事があるだろうに、悪いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030014")

	change_face(Actor002,"Normal")

	--★★クラリス★★:いいえいいえ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030015")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クラリス★★:ノワールくんのお役に立てるのは<br>わたしもとっても嬉しいので～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:リアムさんが<br>教えてくれるんじゃないのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030018")

	change_face(Actor002,"Normal")

	--★★クラリス★★:リアムさんはお忙しいので～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030019")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クラリス★★:それに、誰かに教えることは<br>わたしにとっても良い経験になるって
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★クラリス★★:わたしもリアムさんから<br>ハーブのお世話のしかたを教わってるんです～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030022")


	--★★クラリス★★:最初は難しく感じるかもしれませんけど<br>毎日やっていればすぐコツをつかめますよ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうなのか<br>俺はこういうの詳しくないから、よろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_03030024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クラリス★★:はい、お任せください～！
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030025")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クラリス★★:それではクラリス特別ハーブ講座<br>始まり始まり～です～！
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","CO_101064_03030026")

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
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
