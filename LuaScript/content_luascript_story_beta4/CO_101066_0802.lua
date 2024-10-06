-- このluaスクリプトは、CO_101066_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {-0.098,0.0413,0.1225,0,210,98}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:ワシはかつて、冒険者仲間とパーティを組み<br>世界を股にかけた大冒険をしておった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020002")


	--★★ブレイズ★★:おぬしは信じぬかもしれんが<br>ワシって本当にすごい大魔法使いだったんじゃぞ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020003")

	open_select_window_tag(Actor001,"Normal","CO_101066_08020005","CO_101066_08020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:信じるよ<br>実際、あんたの魔法はすごかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020008")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:おや？ずいぶん素直じゃのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020009")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:信じられな～い！って言われる準備しとったのに<br>ワシ、ちょっと拍子抜けじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:本音を言うと信じられない<br>今のあんたを見てるとさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020012")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:けど、あの魔法を見せられたら<br>信じざるを得ない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020013")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉっふぉ<br>論より証拠ってやつじゃのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020014")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ってことは、あんたが話してた冒険の話は<br>全部本当にあったことなんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0020")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:何度もそう言ったじゃろう<br>まったく、疑り深いヤツじゃのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020017")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:こうなったら<br>おぬしが信用してくれるまで
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020018")


	--★★ブレイズ★★:夜通しかけてワシと仲間たちの冒険譚を<br>聞かせてやりたいところじゃが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020019")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:納得のいく話をしてやれんのが<br>残念でならぬ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020022")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0021")
-- ▲直接出力

	--★★ブレイズ★★:…最後の冒険の地で、<br>ワシらはバルバロイどもに襲われた
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020023")


	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020024")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ワシは懸命に戦った。だが致命傷を与えられず<br>そのうちに、どんどん劣勢になっていった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020025")


	--★★ブレイズ★★:――気づいたとき、ワシはベッドの上じゃった<br>ワシはキラーズに救助されたんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020026")


	--★★ブレイズ★★:そのときワシは『キラーズ因子』がなければ<br>バルバロイを倒せぬと知った
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020027")


	--★★ブレイズ★★:そしてワシには、バルバロイに対抗できるほどの<br>キラーズ因子がないことも同時に知らされた
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020028")

-- ▼直接出力
setup_small_camera_end(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:ワシは絶望したよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020029")


	--★★ブレイズ★★:どんなに努力して会得した魔法も<br>バルバロイとの戦いにおいては無意味じゃった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020030")


	--★★ブレイズ★★:おぬしのような<br>資格をもつ者の力にはかなわないのだと
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020031")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…それでもバルバロイに抗い続けることが<br>生き残ったワシに出来る唯一のことじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020033")


	--★★ブレイズ★★:だからワシはバルバロイの研究を始めた<br>奴らを必ず根絶するためにの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020034")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0001")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:他の仲間は…どうなったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020035")


	--★★ノワール★★:あんたには仲間がいたんだろ？<br>バルバロイとの戦いのあと、その人たちは…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020036")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:………
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0021")
-- ▲直接出力

	--★★ブレイズ★★:わからん
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020038")

-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
on_parent(sword_01,Actor002, "Loc_weapon_constrint_R",weapon_offset)
on_active(sword_01)
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わからん、って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020040")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:この剣は<br>ワシを助けたキラーズから渡されたものじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020042")


	--★★ブレイズ★★:ワシを見つけたとき<br>傍らにあったと言っておった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020043")

	change_face(Actor002,"Sad")

	--★★ブレイズ★★:だがワシは、その剣の持ち主のことを思い出せん<br>頭の中からぽっかり抜け落ちているように
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020044")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0021")
-- ▲直接出力

	--★★ブレイズ★★:恐らくはバルバロイに<br>『存在』を喰いつくされたのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
off_parent(sword_01)
off_active(sword_01)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020047")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:キラーズが拾っておいてくれたおかげで<br>ワシの手元にはたくさんの思い出の品が残った
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020048")


	--★★ブレイズ★★:そのおかげでワシは<br>どんな冒険をしたかを思い出せる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ブレイズ★★:だが、そのとき隣に誰がいたかは<br>どんなに思い出そうとしても思い出せんのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020050")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:とても大切な…忘れてはいけない人たちが<br>そこにいたはずなのに…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020051")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:いってみれば、今ワシに遺っているのは<br>つぎはぎの記憶なのかもしれんな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020052")


	--★★ブレイズ★★:だが、それをワシがまだ覚えているうちに<br>すべてを失ってしまう前に、ワシは…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020053")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ブレイズ先生…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_08020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:…しめっぽい話をしてしまったのう<br>老いぼれのひとりごとと思うてくれい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020055")


	--★★ブレイズ★★:もし気が向いたら覚えておいてくれ<br>偉大な魔法使いとその仲間の冒険譚をな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_08020056")

-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
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
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {-0.098,0.0413,0.1225,0,210,98}
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
