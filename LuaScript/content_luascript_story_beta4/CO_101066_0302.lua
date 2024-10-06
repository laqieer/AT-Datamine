-- このluaスクリプトは、CO_101066_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset1 = {0,0,0,0,0,0}
sword_02 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset2 = {-0.098,0.0413,0.1225,0,210,98}
on_parent(sword_02,Actor002, "Loc_weapon_constrint_R",weapon_offset2)
on_active(sword_02)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera004)
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:それじゃ…まずはこいつからいくかのう<br>ほれ、この剣を持ってみい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020002")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end(RndCamera004)
setup_small_camera_start(Camera001)
DontChangeRandomCamera(false)
off_parent(sword_02)
off_active(sword_02)
PlayActionDirect(Actor002,"to Std_Loop")
on_parent(sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset1)
on_active(sword_01)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:持ったけど…で？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020004")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:さあ、その剣からキラーズを顕現させるのじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020005")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:はあ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020006")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:剣の祭壇では<br>ティルちゃんを呼び出したんじゃろ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020007")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:そのときと同じようにやってみい<br>ほれ！ほれっ！！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えええ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020009")

	open_select_window_tag(Actor001,"Normal","CO_101066_03020011","CO_101066_03020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:よし！それじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020014")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:………って、やりかたわかんないよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020015")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:なんじゃ、不甲斐ないのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:だが、なにごともやってみようとする<br>その心意気やよしじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:そんなこと無理だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大体、キラーズの顕現って<br>そういうものじゃないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020020")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:そうかのう？おぬしならこれくらい<br>できるような気がするんじゃがのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020021")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0017")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:簡単に諦めるのはよくないとワシは思うぞ<br>どんな状況でも足掻いていかんとな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:うーむ。これが一番やりたかったんじゃが<br>まぁしかたないのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020024")


	--★★ブレイズ★★:それじゃ…気を取り直して、<br>どんどん実験していくぞい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020025")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（不安だ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_03020026")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end()
off_parent(sword_01)
off_active(sword_01)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:まずはおぬしの潜在能力をチェックじゃ<br>目隠しで武具の種類当てをするぞい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020028")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0032")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっと、これが剣でこれが槍でこれが…<br>…なんだ、このぬるぬるするやつ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020029")

	change_face(Actor002,"Anger")

	--★★ブレイズ★★:次は身体能力の測定じゃ<br>これをこうして、こう！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020030")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_CO_101062_0602_Massage_Bakibaki")
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力

	--★★ノワール★★:ちょ、待っ！待って！<br>色々曲がっちゃいけないほうに曲がってるから！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020032")

	change_face(Actor002,"Smile")

	--★★ブレイズ★★:次はこれじゃ！はい、あーん！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:むぐっ…ごくんっ<br>ちょ、いきなり口に突っ込むなって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020034")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、あはは、なんだこれ<br>笑いが止まらな…あははあはははははは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020035")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0046")
-- ▲直接出力

	--★★ブレイズ★★:ふんふん、なるほどのう<br>それじゃ次は――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020036")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
hide_image(BLACK_WHITE_TIME)
setup_small_camera_start(Camera001)
change_face(Actor001,"Sad")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はぁ、はぁ…<br>さ、散々な目にあった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020038")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0046")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ふむふむ。なるほどのう<br>それじゃ、次は――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020039")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちょ、ちょっと待ってくれ！<br>まだやるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:訳が分からないことばかりさせて…<br>これ、本当に意味があるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020041")


	--★★ブレイズ★★:さあ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020042")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:さあ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020043")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:今は無意味でもこれから意味が出るかもしれん<br>その日のためにデータは多くとっておくのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020044")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:いいか、ノワールよ。研究というのは<br>長い目でじっくり観察することが必要なんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020045")


	--★★ブレイズ★★:なにが正しくて、なにが間違っているかは<br>簡単には判断できんものじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020046")


	--★★ブレイズ★★:だからこそ観察し続けるのじゃ<br>あらゆるものをな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020047")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020049")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:しかし…なかなか思ったような結果が出んのう<br>髭の調子が悪いからじゃろうか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020050")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ちと、髭を整えてみるか<br>これをこうしてチョチョイチョイと…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020051")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:…よし！これでばっちりじゃ<br>どうじゃ？きまってるじゃろ～？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020052")


	--★★ノワール★★:（さっきと変わらないように見えるけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_03020053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:髭がきまるとなんだか冴えてくるのう～<br>むむむ…さっきの実験結果…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020054")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0046")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:なるほど、そういうことか！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020055")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうこと！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020056")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力

	--★★ブレイズ★★:ということは、あの仮説も証明できるかもしれん<br>うむ…研究がさらに捗りそうじゃ～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（研究に協力するって言ったはいいけど<br>なんか…よくわからないな、この人）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_03020058")


	--★★ノワール★★:（もしかしなくても、俺、早まったかな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_03020059")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C110_35_Food_Eat")
wait_time(1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:って、またあの塩クッキー食べてる！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020061")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0011")
-- ▲直接出力

	--★★ブレイズ★★:塩クッキーの塩分が脳にビシビシくるのう～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020062")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ノワール、お主にも分けてやろう<br>塩分とったらもうひと頑張りじゃからな！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_03020063")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、俺はいいって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_03020064")

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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset1 = {0,0,0,0,0,0}
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset2 = {-0.098,0.0413,0.1225,0,210,98}
	InitializeLoad_Preload()
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
