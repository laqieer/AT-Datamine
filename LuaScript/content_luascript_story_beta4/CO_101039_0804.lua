-- このluaスクリプトは、CO_101039_0804.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101033","001","101033001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ノワールくん、どうしよう…<br>私のせいだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040002")


	--★★フレン★★:私が競技大会なんて余計なことを言い出したから<br>みんな、余計に険悪になっちゃった
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040003")


	--★★フレン★★:このままじゃ競技大会どころか<br>陸上部がバラバラになっちゃうよ…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040004")

	open_select_window_tag(Actor001,"Normal","CO_101039_08040006","CO_101039_08040007","CO_101039_08040008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:これで諦めちゃうのか？<br>フレンは陸上部を盛り上げたいんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか<br>みんなを仲直りさせる方法はあるはずだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に頑張ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040012")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ありがとう、ノワールくん…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだかフレンらしくないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040015")

	change_face(Actor002,"Sad")

	--★★フレン★★:私らしくない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん。俺の知ってるフレンは<br>いつも元気で前向きで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:困難なことにも<br>物怖じせずに立ち向かっていく女の子だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスすら怖がらないフレンが<br>こんなことでヘコたれるなんて、らしくないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:そっか…そうだね<br>私らしくなかったよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あそこまで仲がこじれてしまうと<br>正直、修復は難しいかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:競技大会は諦めようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040023")

-- ▼直接出力
PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:そんな…！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Smile")

	--★★リオネス★★:スペシャルブレンドりんごジュース<br>おまちどうーっ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","N","CO_101039_08040026")

	close_cutin()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リオネス、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:フレン<br>方向性の違うふたつでも混じり合えるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040029")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:諦めずにふたりを説得してみよう<br>キミの想いをぶつければ、きっとわかってくれる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040030")


	--★★ノワール★★:この場所を、陸上部を失いたくないという思いは<br>みんなも同じはずだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08040031")

	change_face(Actor002,"Sad")

	--★★フレン★★:ノワールくん…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08040033")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101033","001","101033001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
