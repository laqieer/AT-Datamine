-- このluaスクリプトは、CO_101011_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
prop001 = setup_prop_object(10201016)
set_pos(prop001 , {0.338,0.501,-0.3})
prop002 = setup_prop_object(10201016)
set_pos(prop002 , {0.338,0.501,-0.15})
prop003 = setup_prop_object(10201016)
set_pos(prop003 , {0.338,0.501,0})
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
keep_ik_lookat(Actor001, Actor002, "J_Head")
keep_ik_lookat(Actor002, Actor001, "J_Head")
keep_ik_lookat(Actor003, Actor002, "J_Head")
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
load_image("104000070", "content_still_10400007_image", "104000070_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:今日はね<br>コインのコレクションを見せてあげようと思って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:コインのコレクション？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:ノワールにあげたやつ以外にも<br>ラッキーコインってたくさんあるのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワールにその素晴らしさを<br>あらためて教えてあげようと思って！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_04020007","CO_101011_04020008")
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
	change_face(Actor001,"Sad")

	--★★ノワール★★:え…<br>い、いや、俺はいいよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020010")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:まあまあ。今日は黙って<br>わたしの講義を聞いときなさいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:損はしないから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020012")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういう問題じゃあないんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ<br>おもしろそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:コインなんて<br>お金としての用途しか考えたことなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020016")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:フフン<br>まあ、フツーの人はそうよね～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020017")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:たとえばこれ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020019")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それって<br>ログレスで流通してるコインじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020020")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:そうなんだけど<br>それだけじゃないんだなあ～これが
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020021")


	--★★ギネヴィア★★:このコインはね<br>わたしが産まれた年に製造されたものなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020022")


	--★★ギネヴィア★★:自分が産まれた年に製造されたコインを<br>持っていると
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020023")


	--★★ギネヴィア★★:金運が良くなると言われているわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:それからこっちの大きいのは<br>海の向こうの国で使われているコインでね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020026")


	--★★ギネヴィア★★:運命の人と出会わせてくれるっていうんで<br>ブリテン平定戦役のときに持ってたら…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…持ってたら？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:持ってたんだけど<br>と、特になにも効果はなかったかな！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020030")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:えっと、あー…<br>そうだ、今日はノワールにこれをあげる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020031")

	open_select_window_tag(Actor001,"Normal","CO_101011_04020033","CO_101011_04020034","CO_101011_04020035")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ずいぶん古びたコインだな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、大事にするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:どういたしまして
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020040")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ずっと身に着けててね<br>あなたをケガや病気から守ってくれるはずだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020041")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この古びたコインには<br>どんな効果があるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020043")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:これはね、厄除けのコインなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:身に着けていれば<br>ケガや病気から守ってくれるはずよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020045")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020047")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ラッキーコインって<br>いろんな種類があるんだな、知らなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:今度時間があったら<br>他のコインのことも教えてあげるわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020049")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…それは？<br>コインじゃなくてガラス玉に見えるけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020051")

-- ▼直接出力
ShowImageItem(104000070)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:これ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020053")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それも<br>キミのコレクションのひとつ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_04020054")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:そう。わたしのコレクションのなかでも<br>一番大切なもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020055")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:大切な人からもらった<br>大切な大切な宝物
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_04020056")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
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
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
load_image_preload("104000070", "content_still_10400007_image", "104000070_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
