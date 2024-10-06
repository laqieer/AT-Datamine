-- このluaスクリプトは、MA_01C109_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
 --PlayPartVoice("ケイ","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★知将ケイ★★:…そうか！<br>それは大変助かる、と伝えてくれ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C109_060002")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor001,Camera001,EntryData110071_01_07,CameraAssetBundleName110071_01,CameraPos110071_01_107)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:なにがあったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_060003")

-- ▼直接出力
turn_chara(Actor002,122,0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:先ほど<br>コルベニック城のペレス王から連絡があってな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:バルバロイおよびローマとの戦いへの<br>協力は惜しまない、とのことだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_060006","MA_01C109_060007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:<ruby=シルバタブラナイツ>銀卓騎士団</ruby>が協力してくれるのか<br>それは心強いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_060009")

-- ▼直接出力
 --PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★知将ケイ★★:聖杯に関しての情報も<br>判明次第連絡してくれるそうだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01C109_060011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…あの人の犠牲は<br>無駄にはならなかったようだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:良かった<br>ブライアンや…父さんのおかげかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_060014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうだな<br>あの戦いあっての、この結果だろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それに、お前が見事GSを果たしたことも<br>ぺレス王たちを動かした要因と思う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060016")

	goto Block1end

::Block1end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
turn_chara(Actor002,122,0)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:みんなは父さんのこと<br>すっかり忘れてしまったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_060018")

-- ▼直接出力
 --PlayPartVoice("ランスロット","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、俺とお前だけは<br>あの人の想い出を持ち合わせている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060019")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ランスロット★★:それだけではない<br>聖遺物ジョワイユの伝承は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060020")


	--★★ランスロット★★:次なる<dot>継承者へと継承</dot>され<br>未来永劫語り継がれていく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:聖遺物化したことを<br>あの人は悲しんではいないだろうし
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺たちは誇りに思わなくてはならない<br>キラーズとして、マスターとして戦うことを
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C109_060024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ、そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_060025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
