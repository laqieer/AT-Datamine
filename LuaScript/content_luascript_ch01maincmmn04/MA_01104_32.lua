-- このluaスクリプトは、MA_01104_32.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_01","113011_01_h")
Include("content_adv_advsmall_113011_01","Template113011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName113011_01,CameraPos113011_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_01,CameraPos113011_01_006)
	InitializeTemplateRandomCamera113011_01()
	InitializeTemplate113011_01()
-- ▼直接出力
set_pos(Actor002,{1.312, 0, 1.716})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera001)
-- ▲直接出力

	--★★ギネヴィア★★:（…それに、ケイが言ってた『妖精殺し』──）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","L","MA_01104_320002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:『妖精』って確か…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320003")

-- ▼直接出力
Appear(Actor002)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,CharaPos113011_01_006[1],CharaPos113011_01_006[2],CharaPos113011_01_006[3],1.8 ) --ポジションに移動
setup_small_camera_start()
wait_time(1.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ギネマウア★★:あら。やっぱりいた
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320005")


	--★★ギネヴィア★★:ねえ、『妖精』って確か<br>円卓の騎士が守ってたのよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:そのはずだけど…、どうしたの？<br>ブリテンの伝承によれば──
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320007")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★ギネマウア★★:『どんな願いでも叶える』<br>と言われる伝説の遺物──『聖杯』
	Talk(Actor002,"NPCNAME_0070","speech","N","MA_01104_320008")


	--★★ギネマウア★★:世が混迷の時代に至ったときに<br>ブリテンのどこかに現れるという
	Talk(Actor002,"NPCNAME_0070","speech","N","MA_01104_320009")


	--★★ギネマウア★★:歴史すら変えてしまうかもしれないその聖杯を<br>悪用されぬよう円卓の騎士は探す使命をもつ
	Talk(Actor002,"NPCNAME_0070","speech","N","MA_01104_320010")


	--★★ギネマウア★★:そして『妖精』が<br>いつか現れる聖杯への道しるべとなる
	Talk(Actor002,"NPCNAME_0070","speech","N","MA_01104_320011")

	close_cutin()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:豊かな教養、感服するわ<br>伝説とかマユツバだけど
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320012")


	--★★ギネヴィア★★:いつどこに出てくるかわかんない聖杯を<br>妖精さん守りながら待つってワケ、気の長い話…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320013")


	--★★ギネマウア★★:ここまではお子様ですら知っているおとぎ話
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320014")

	PlayAction(Actor002,"to  Std_No")

	--★★ギネマウア★★:だけど、その妖精を殺した者がいる
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320015")


	--★★ギネヴィア★★:…────それが『妖精殺し』…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:円卓の騎士や王族のごく一部しか<br>知らない話になるけど
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:聞かせて？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:妖精はログレスから遠く離れた地<br>聖杯城に住まわされていたの
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320020")


	--★★ギネマウア★★:ある円卓の騎士が聖杯城に派遣され<br>妖精守護の任に就いていた
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320021")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネマウア★★:けれど8年ほど前のこと<br>その騎士は突如妖精を殺害し──失踪
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:…その『妖精殺し』って、どんなやつ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320024")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:それがね、わからないの
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:わからないってなによ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320026")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:妖精を守るべく<br>身分は隠されているから
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320027")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネマウア★★:ログレスでも限られた者しか妖精殺しを知らない<br>もちろん私もまったくわかりません
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………なんで、殺しちゃったのよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320029")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:それも、皆目
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:…ふぅん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320031")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:それはそうとギネヴィア？
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320032")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:なによ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01104_320033")


	--★★ギネマウア★★:ぼっちメシ、やめたら？
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01104_320034")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Shy")

	--★★ギネヴィア★★:ウッ、うるしゃァい…………！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01104_320036")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
