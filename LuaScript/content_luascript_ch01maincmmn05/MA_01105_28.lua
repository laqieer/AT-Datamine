-- このluaスクリプトは、MA_01105_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_03","113011_03_h")
Include("content_adv_advsmall_113011_03","Template113011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos113011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_002)
	InitializeTemplateRandomCamera113011_03()
	InitializeTemplate113011_03()
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,1.22,1.6,0.106)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Ginevia_Theme")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001, Actor003, "J_Head")
lookat_weight(Actor001,1.0,0.5,1.0,0.2)
lookat_delay_weight(Actor001, {1.0,0.5,1.0,0.2} ,1.0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003, Actor001, "J_Head")
lookat_weight(Actor003,1.0,0.5,1.0,0.2)
lookat_delay_weight(Actor003, {1.0, 0.5, 1.0, 0.5},1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113012)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネマウア★★:「ある日、貧しき娘は異国のコインを拾いました<br>しかし自分の国でそれは使えませんでした」
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280002")


	--★★ギネマウア★★:「娘は願いました<br>リッチになりたい、と」
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280003")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:そんな話だった？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:欠落していく記憶には個人差があるのね<br>だけど、私は覚えているわ、まだ…
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280005")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:つ、続き、続きを、おねがい…、忘れたくない…<br>パパもキャメリアードのことも…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280006")


	--★★ギネマウア★★:…<br>「異国のコインは答えました」
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280007")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor003, -6.858, 0)
lookat_delay_weight(Actor003, 1.2, 0.5, 1.0, 0.2,1.0)
keep_delay_ik_lookat_object(Actor003,nil,"kara",0.5)

se_play("SE_ADV_MA_01105_28_Knock")
wait_time(1.0)
lookat_delay_weight(Actor001, 1.2, 0.5, 1.0, 0.2,1.0)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.2)
wait_time(1.5)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:…はい
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280009")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:こんな夜更けに、ご用？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280011")


	--★★ノワール02★★:そのままで、聞いてくれ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280012")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール02★★:俺、海を越えて北の島にディナタンと<br>父さん、母さんと４人で住んでいたんだ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280014")


	--★★ノワール02★★:…けど、父さんがなにも言わずに<br>そこを離れることになって
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280015")


	--★★ノワール02★★:俺とディナタンと母さんは<br>カレドニアの外れに移り住んだ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280016")


	--★★ノワール02★★:そこは遊ぶところなんてなにもなくてさ<br>俺は家族がいればそれでいいと思ってたけど
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280017")

	change_face(Actor004,"Sad")

	--★★ノワール02★★:母さんが、死んで──
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280018")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280019")


	--★★ノワール02★★:誰も本当のことを言ってくれなかった
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280021")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ノワール02★★:帰って来ない人を恨みもした<br>だけど、もしかしたら
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280022")


	--★★ノワール02★★:本当は、隠さなきゃいけないほど…<br>忘れたほうがいいほど辛い現実なのかもしれない
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280023")


	--★★ノワール02★★:けど、それでも──
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280025")

	change_face(Actor004,"Normal")

	--★★ノワール02★★:忘れて…平気な顔なんて出来ない、よな
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01105_280027")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.6, FADE_TIME)
wait_time(1.0)
se_play("SE_ADV_MA_01105_28_DoorOpen")
wait_time(TIME_ELAPSED + FADE_TIME)
lookat_delay_weight_reset(Actor001 , 1)
lookat_delay_weight_reset(Actor003 , 1)

set_animationcontroller(Actor001, "Chr_502_01_StdController", "to Std_Loop")
Appear(Actor002)
Camera001 = setup_small_camera_resetting(Actor001,CharaPos004,CameraPos004)
wait_time(0.2)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…うん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280029")

-- ▼直接出力
bgm_play("BGM_ADV_Ginevia_Theme")
-- ▲直接出力

	--★★ノワール★★:親孝行、しに行かないか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…うんっ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280031")

	change_face(Actor003,"Smile")

	--★★ギネマウア★★:彼のおかげで<br>土産話に箔がつきますね？
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280032")


	--★★ノワール★★:そのための飾りらしいから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280033")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…ううん。もう、それだけじゃないの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280036")


	--★★ギネマウア★★:ふふ
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01105_280037")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…ごめんなさい、ノワール<br>わたしは、あなたをイイように使おうとしてた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280038")

	open_select_window_tag(Actor002,"Normal","MA_01105_280040","MA_01105_280041","MA_01105_280042")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:傭兵団のもと団長からさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280044")

	change_face(Actor002,"Normal")

	--★★ノワール★★:雇われたからには仕事をしろって<br>教わってるんだよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280045")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:傭兵の流儀ってヤツぅ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280046")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:放っておけないんだよ<br>父親を想う気持ちは俺も同じだから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280048")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ありがと<br>あなたのお父様もきっと素敵な方だったのね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280049")

	change_face(Actor002,"Smile")

	--★★ノワール★★:もちろん<br>憧れだったよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280050")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:この国を出て<br>故郷に帰るついでさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280052")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:いいように使おうとしてたのは<br>お互い様かしら？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280053")

	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:帰りたくってしょうがないよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280054")

	goto Block1end

::Block1end::
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:弱っちくってワガママなわたしを<br>飾り立てる人を探してたのよ、けど本当は──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280056")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(0.9)
se_play("SE_ADV_MA_01105_28_Paper")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:これ。まだ五月だから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280058")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:なに、この紙切れ…<br>『投票用紙：ギネヴィア』…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280059")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor002,"to Bow")
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:五月女王様
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280060")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:誘拐──…されてくださいますか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_280061")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_280062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to  Std_Joy")
wait_time(1.3)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Smile")

	--★★ギネヴィア★★:誘拐、どんとこいよっ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01105_280063")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Ginevia_Theme")
	InitializeLoad_Preload()
	load_area_scene_preload(113012)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
